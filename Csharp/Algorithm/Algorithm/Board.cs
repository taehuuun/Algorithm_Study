namespace Algorithm;

public enum Tile
{
    Empty,
    Wall
}


public class Board
{
    public Tile[,]? Tiles { get; private set; }
    private int _size;
    
    private const char _CIRCLE = '\u25cf';
    
    public void Initialize(int size)
    {
        _size = size;
        Tiles = new Tile[size, size];

        CreateBoard();
    }

    public void Render()
    {
        Console.SetCursorPosition(0, 0);
            
        for(int y = 0; y < _size; y++)
        {
            for(int x = 0; x < _size; x++)
            {
                Console.ForegroundColor = GetTileColor(Tiles[y, x]);;
                Console.Write(_CIRCLE);
            }
                
            Console.WriteLine();
        }
    }
    
    private void CreateBoard()
    {
        for (int y = 0; y < _size; y++)
        {
            for (int x = 0; x < _size; x++)
            {
                if (x == 0 || y == 0 || x == _size - 1 || y == _size - 1)
                {
                    Tiles[y, x] = Tile.Wall;
                }
                else
                {
                    Tiles[y, x] = Tile.Empty;
                }
            }
        }
    }
    
    private ConsoleColor GetTileColor(Tile tile)
    {
        return tile switch
        {
            Tile.Empty => ConsoleColor.Green,
            Tile.Wall => ConsoleColor.Red,
            _ => ConsoleColor.White
        };
    }
}