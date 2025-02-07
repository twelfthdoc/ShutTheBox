using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool dice;
    public bool mainMenu;
    public bool newGame;
    public AudioSource tilesOpeningSound;
    public AudioSource tilesClosingSound;
    public Box box;

    private bool isGameOver = false;
    private bool hasPlayerWon = false;
    [SerializeField] private AudioSource diceSounds;

    // Start is called before the first frame update
    private void Start()
    {
        box = new Box();
        tilesOpeningSound.Play();
    }

    public void RollDice()
    {
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
        var die1 = Random.Range(1, 7);
        var die2 = Random.Range(1, 7);

        // Assign the dice faces    
        var die1Image = GameObject.FindGameObjectWithTag("Die1").GetComponent<Image>();
        die1Image.sprite = Resources.Load<Sprite>($"Textures/Die Face {die1}");

        var die2Image = GameObject.FindGameObjectWithTag("Die2").GetComponent<Image>();
        die2Image.sprite = Resources.Load<Sprite>($"Textures/Die Face {die2}");

        // Find the buttons on the canvas
        var boxButtons = GameObject.FindGameObjectWithTag("Box").GetComponentsInChildren<Button>();

        // Calculate the sum
        var sum = die1 + die2;

        // Highlight corresponding Tiles
        foreach (var tile in box.tiles)
        {
            if (tile.Value == die1 ||
                tile.Value == die2 ||
                tile.Value == sum)
            {
                if (!tile.IsClosed)
                {
                    tile.IsHighlighted = true;
                    boxButtons[tile.Value - 1].interactable = true;
                }
            }
        }

        // Check Game Over situation
        if (!box.tiles.Any(o => o.IsHighlighted))
        {
            isGameOver = true;
            GameOver();
        }
        else
        {
            GameObject.FindGameObjectsWithTag("Button").FirstOrDefault(o => o.name == "Make Selection").SetActive(true);
        }
    }

    public void OnNumberButtonPress(int value)
    {
        if (box.tiles[value - 1].IsHighlighted)
        {
            box.tiles[value - 1].IsSelected = !box.tiles[value - 1].IsSelected;
        }
    }

    public void MakeSelection()
    {
        //var sum = box.tiles.Where(tile => tile.IsSelected).Sum(tile => tile.Value);

        // Find the buttons on the canvas
        var boxButtons = GameObject.FindGameObjectWithTag("Box").GetComponentsInChildren<Button>();

        // Close off all selected Tiles
        foreach (var tile in box.tiles.Where(tile => tile.IsSelected))
        {
            tile.Close();
            boxButtons[tile.Value - 1].gameObject.SetActive(false);
        }

        tilesClosingSound.Play();

        // If all Tiles are closed, the Box is shut and the Player wins
        if (box.tiles.All(o => o.IsClosed))
        {
            hasPlayerWon = true;
            isGameOver = true;
            GameOver();
        }
        else
        {
            GameObject.FindGameObjectsWithTag("Button").FirstOrDefault(o => o.name == "Roll Dice").SetActive(true);
        }
    }

    public void GameOver()
    {
        var newGameButton = GameObject.FindGameObjectsWithTag("Button").First(o => o.name == "New Game");
        newGameButton.SetActive(true);

        var mainMenuButton = GameObject.FindGameObjectsWithTag("Button").First(o => o.name == "Main Menu");
        mainMenuButton.SetActive(true);

        var gameOverText = hasPlayerWon ?
            GameObject.Find("Player Win") :
            GameObject.Find("Game Over");

        if (gameOverText != null)
        {
            gameOverText.SetActive(true);
        }
    }

    public void NewGame()
    {
        box.tiles.Clear();
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

public class Box
{
    public IList<Tile> tiles;

    public Box()
    {
        tiles = new List<Tile>
        {
            new(1),
            new(2),
            new(3),
            new(4),
            new(5),
            new(6),
            new(7),
            new(8),
            new(9),
            new(10)
        };
    }
}

public class Tile
{
    public uint Value { get; }
    public bool IsHighlighted { get; set; }
    public bool IsSelected { get; set; }
    public bool IsClosed { get; private set; }

    public Tile(uint value)
    {
        Value = value;
        IsHighlighted = false;
        IsSelected = false;
        IsClosed = false;
    }

    public void Close()
    {
        if (IsSelected)
        {
            IsSelected = false;
            IsClosed = true;
        }
    }
}