namespace Algorithm;

public class MazeGenerator
{
    public void GenerateBinaryTreeMaze(Tile[,]? tiles)
    {
        if (tiles == null)
        {
            return;
        }
        
        Random random = new();
        int size = tiles.GetLength(0);
        
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                if (x % 2 == 0 || y % 2 == 0)
                {
                    tiles[y, x] = Tile.Wall;
                }
                else
                {
                    tiles[y, x] = Tile.Empty;
                }
            }
        }

        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                if (x == size - 2 && y == size - 2)
                {
                    continue;
                }
                
                if (x % 2 == 0 || y % 2 == 0)
                {
                    continue;
                }

                if (y == size - 2)
                {
                    tiles[y, x+1] = Tile.Empty;
                    continue;
                }

                if (x == size - 2)
                {
                    tiles[y+1, x] = Tile.Empty;
                    continue;
                }

                if (random.Next(0, 2) == 0)
                {
                    tiles[y, x+1] = Tile.Empty;
                }
                else
                {
                    tiles[y+1, x] = Tile.Empty;
                }
            }
        }
    }

    public void GenerateSideWind(Tile[,]? tiles)
    {
        if (tiles == null)
        {
            return;
        }
        
        int size = tiles.GetLength(0);
        
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                if (x % 2 == 0 || y % 2 == 0)
                {
                    tiles[y, x] = Tile.Wall;
                }
                else
                {
                    tiles[y, x] = Tile.Empty;
                }
            }
        }
        
        Random random = new();
        for (int y = 0; y < size; y++)
        {
            int count = 0;
            for (int x = 0; x < size; x++)
            {
                if (x % 2 == 0 || y % 2 == 0)
                {
                    continue;
                }

                if (x == size - 2 && y == size - 2)
                {
                    continue;
                }
                
                if (y == size - 2)
                {
                    tiles[y, x+1] = Tile.Empty;
                    continue;
                }

                if (x == size - 2)
                {
                    tiles[y+1, x] = Tile.Empty;
                    continue;
                }
                
                if (random.Next(0, 2) == 0)
                {
                    tiles[y, x + 1] = Tile.Empty;
                    count++;
                }
                else
                {
                    int randomIndex = random.Next(0, count);
                    tiles[y+1, x - randomIndex * 2] = Tile.Empty;
                    count = 1;
                }
            }
        }
    }
}