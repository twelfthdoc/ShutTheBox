using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Box box;
    private bool IsGameOver = false;
    private bool HasPlayerWon = false;

    // Start is called before the first frame update
    private void Start()
    {
        box = new Box();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
    }

    private void RollDice()
    {
        // Roll 2d6 and save their result
        var die1 = Random.Range(1, 7);
        var die2 = Random.Range(1, 7);

        // Calculate the sum
        var sum = die1 + die2;

        // Highlight corresponding Tiles
        foreach (var tile in box.tiles)
        {
            if (tile.Value == die1 ||
                tile.Value == die2 ||
                tile.Value == sum)
            {
                tile.IsHighlighted = true;
            }
        }

        // Check Game Over situation
        if (!box.tiles.Any(o => o.IsHighlighted))
        {
            IsGameOver = true;
        }
    }

    private void MakeSelection()
    {
        // Close off all selected Tiles
        foreach (var tile in box.tiles.Where(tile => tile.IsSelected))
        {
            tile.Close();
        }

        // If all Tiles are closed, the Box is shut and the Player wins
        if (box.tiles.All(o => o.IsClosed))
        {
            HasPlayerWon = true;
            IsGameOver = true;
        }
    }

    private void Reset()
    {
        box.tiles.Clear();
        box = new Box();
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