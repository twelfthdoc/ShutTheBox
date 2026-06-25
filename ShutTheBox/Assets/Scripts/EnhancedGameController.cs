using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class EnhancedGameController : GameController
    {
        public int powerPoints;
        public AudioSource powerUpSound;
        public AudioSource explosionSound;

        // Start is called before the first frame update
        private new void Start()
        {
            powerPoints = 0;
            UpdatePowerPoints();
            base.Start();
        }

        // Rolls the dice
        public override void RollDice()
        {
            // Play one of the dice roll sounds
            var clip = Resources.Load<AudioClip>($"Audio/Dice {Random.Range(1, 7)}");

            if (clip != null)
            {
                diceSounds.PlayOneShot(clip);
            }
            else
            {
                Debug.Log("Could not find Audio file.");
            }

            // Roll 2d6 and save their result
            die1 = RollSingleD6();
            die2 = RollSingleD6();

            // Assign the dice faces    
            var die1Image = GameObject.FindGameObjectWithTag("Die1").GetComponent<Image>();
            die1Image.gameObject.SetActive(true);
            die1Image.sprite = Resources.Load<Sprite>($"Textures/Die Face {die1}");

            var die2Image = GameObject.FindGameObjectWithTag("Die2").GetComponent<Image>();
            die2Image.gameObject.SetActive(true);
            die2Image.sprite = Resources.Load<Sprite>($"Textures/Die Face {die2}");

            // A Power Point is obtained when a double is rolled
            // Power Points are only obtained in Enhanced Mode, and not in Hard Mode
            if (die1 == die2)
            {
                IncreasePowerPoints();
                Resources.FindObjectsOfTypeAll<Button>().First(o => o.name == "Next").gameObject.SetActive(true);
                return;
            }

            BoxButtons();
            PowerButton();
            GameOverCheck();
        }

        // Enables/Disables the Power Button
        private void PowerButton() => GameObject.Find("PowerButton").GetComponent<Button>().interactable = powerPoints >= (int) PowerPointLevels.Level1;

        // Check Game Over situation
        private void GameOverCheck()
        {
            if (!box.tiles.Any(o => o.IsHighlighted) && powerPoints < (int) PowerPointLevels.Level1)
            {
                GameOver();
            }
            else
            {
                SelectionButton();
            }
        }

        // Game logic for how to handle a valid selection
        public override void MakeSelection()
        {         
            // Find the buttons on the canvas
            var boxButtons = GameObject.FindGameObjectWithTag("Box").GetComponentsInChildren<Button>();

            // Close off all selected Tiles
            foreach (var tile in box.tiles.Where(tile => tile.IsSelected))
            {
                tile.Close();

                var button = boxButtons.First(o => o.name == tile.Value.ToString());
                button.image.enabled = false;
                button.enabled = false;

                var closed = GameObject.FindGameObjectWithTag("Box").GetComponentsInChildren<Image>().First(o => o.name == $"{tile.Value}Closed");
                closed.enabled = true;
            }

            tilesClosingSound.Play();

            // Deselect all other Tiles
            foreach (var tile in box.tiles)
            {
                tile.IsHighlighted = false;
            }

            foreach (var button in boxButtons)
            {
                button.interactable = false;
            }

            // If all Tiles are closed, the Box is shut and the Player wins
            if (box.tiles.All(o => o.IsClosed))
            {
                hasPlayerWon = true;
                GameOver();
            }
            else
            {
                foreach (var button in GameObject.FindGameObjectWithTag("Box").GetComponents<Button>())
                {
                    button.onClick.RemoveAllListeners();
                }

                Resources.FindObjectsOfTypeAll<Button>().First(o => o.name == "RollDice").gameObject.SetActive(true);

                if (GameObject.FindGameObjectWithTag("Die3").GetComponent<Image>().enabled)
                {
                    GameObject.FindGameObjectWithTag("Die3").GetComponent<Image>().enabled = false;
                }
            }
        }

        // Enhanced Mode: Increases Power Points by 1
        public void IncreasePowerPoints()
        {
            powerPoints++;
            powerUpSound.Play();
            UpdatePowerPoints();
        }

        // Enhanced Mode: Decreases the value of one of the dice by 1 (1 becomes a 6)
        public void Nudge(int dieNumber)
        {
            if (powerPoints < (int) PowerPointLevels.Level1)
            {
                SelectionButton();
                PowerButton();
                return;
            }

            powerPoints -= (int) PowerPointLevels.Level1;
            UpdatePowerPoints();

            var dieImage = GameObject.FindGameObjectWithTag($"Die{dieNumber}").GetComponent<Image>();

            if (dieNumber == 1)
            {
                die1--;
                if (die1 == 0) die1 = 6;
                dieImage.sprite = Resources.Load<Sprite>($"Textures/Die Face {die1}");
            }
            else if (dieNumber == 2)
            {
                die2--;
                if (die2 == 0) die2 = 6;
                dieImage.sprite = Resources.Load<Sprite>($"Textures/Die Face {die2}");
            }

            BoxButtons();
            PowerButton();
            GameOverCheck();
        }

        // Enhanced Mode: Increases the value of one of the dice by 1 (6 becomes a 1)
        public void Bump(int dieNumber)
        {
            if (powerPoints < (int) PowerPointLevels.Level1)
            {
                SelectionButton();
                PowerButton();
                return;
            }

            powerPoints -= (int) PowerPointLevels.Level1;
            UpdatePowerPoints();

            var dieImage = GameObject.FindGameObjectWithTag($"Die{dieNumber}").GetComponent<Image>();

            if (dieNumber == 1)
            {
                die1++;
                if (die1 == 7) die1 = 1;
                dieImage.sprite = Resources.Load<Sprite>($"Textures/Die Face {die1}");
            }
            else if (dieNumber == 2)
            {
                die2++;
                if (die2 == 7) die2 = 1;
                dieImage.sprite = Resources.Load<Sprite>($"Textures/Die Face {die2}");
            }

            BoxButtons();
            PowerButton();
            GameOverCheck();
        }

        // Enhanced Mode: Rolls a 3rd die for one turn
        public void ExtraDie()
        {
            if (powerPoints < (int) PowerPointLevels.Level2)
            {
                SelectionButton();
                PowerButton();
                return;
            }

            powerPoints -= (int) PowerPointLevels.Level2;
            UpdatePowerPoints();

            var die3 = RollSingleD6();

            var die3Image = GameObject.FindGameObjectWithTag("Die3").GetComponent<Image>();
            die3Image.sprite = Resources.Load<Sprite>($"Textures/Die Face {die3}");
            die3Image.enabled = true;

            BoxButtonsForThreeDice(die3);
            PowerButton();
            GameOverCheck();
        }

        // Enhanced Mode: Sets up the Box Buttons selection for three dice
        protected void BoxButtonsForThreeDice(int die3)
        {
            // Calculate the sum
            sum = die1 + die2 + die3;

            // Get valid Tile selection
            var tiles = GetValidTiles();

            // Find the buttons on the canvas
            var boxButtons = GameObject.FindGameObjectWithTag("Box").GetComponentsInChildren<Button>();

            // Highlight corresponding Tiles
            foreach (var tile in box.tiles)
            {
                if (!tile.IsClosed && tiles.Contains(tile))
                {
                    HighlightTile(tile, boxButtons.First(o => o.name == tile.Value.ToString()));
                }
            }
        }

        // Enhanced Mode: Closes any Tile immediately
        public void Eradicate()
        {
            if (powerPoints < (int) PowerPointLevels.Level3)
            {
                SelectionButton();
                PowerButton();
                return;
            }

            powerPoints -= (int) PowerPointLevels.Level3;
            UpdatePowerPoints();

            // Hide the dice and show the Big Red Button™
            GameObject.FindGameObjectWithTag("Die1").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Die2").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Die3").GetComponent<Image>().enabled = false;
            Resources.FindObjectsOfTypeAll<Button>().First(o => o.name == "BigRedButton").gameObject.SetActive(true);

            // Find the buttons on the canvas
            var boxButtons = GameObject.FindGameObjectWithTag("Box").GetComponentsInChildren<Button>();

            foreach (var tile in box.tiles.Where(t => !t.IsClosed))
            {
                HighlightTile(tile, boxButtons.First(o => o.name == tile.Value.ToString()));
            }
        }

        // Enhanced Mode: Eradicate callback function
        public void Boom()
        {
            var count = box.tiles.Count(tile => tile.IsSelected);
            if (count != 1) return;

            GameObject.Find("BigRedButton").SetActive(false);
            explosionSound.Play();
            MakeSelection();
        }

        // Enhanced Mode: Updates the Power Points text
        public void UpdatePowerPoints()
        {
            var points = FindObjectsOfType<TextMeshProUGUI>().First(t => t.name == "PowerPoints");

            if (powerPoints < (int)PowerPointLevels.Level1)
            {
                points.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF); // White
            }
            else if (powerPoints < (int)PowerPointLevels.Level2)
            {
                points.color = new Color32(0xB0, 0x8D, 0x57, 0xFF); // Bronze
            }
            else if (powerPoints < (int)PowerPointLevels.Level3)
            {
                points.color = new Color32(0xAA, 0xAA, 0xAD, 0xFF); // Silver
            }
            else
            {
                points.color = new Color32(0xD4, 0xAF, 0x37, 0xFF); // Gold
            }

            points.text = powerPoints.ToString();
        }

        // Enhanced Mode: Handles what happens when a double is rolled
        public void GoToNextRoll()
        {
            GameObject.FindGameObjectWithTag("Die1").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Die2").GetComponent<Image>().enabled = false;
            Resources.FindObjectsOfTypeAll<Button>().First(o => o.name == "RollDice").gameObject.SetActive(true);
        }
    }
}