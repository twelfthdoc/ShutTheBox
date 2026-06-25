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