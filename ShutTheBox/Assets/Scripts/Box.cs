using System.Collections.Generic;

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
