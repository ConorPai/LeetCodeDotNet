public class IslandPerimeterDemo {
    public int IslandPerimeter(int[,] grid) {
        
        int nTotalLength = 0;
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if (grid[i,j] == 1)
                {
                    if ((i - 1 < 0) || (i - 1 >= 0 && grid[i - 1,j] == 0))
                        nTotalLength++;

                    if ((j - 1 < 0) || (j - 1 >= 0 && grid[i,j - 1] == 0))
                        nTotalLength++;

                    if ((i + 1 >= grid.GetLength(0)) || (i + 1 < grid.GetLength(0) && grid[i + 1,j] == 0))
                        nTotalLength++;

                    if ((j + 1 >= grid.GetLength(1)) || (j + 1 < grid.GetLength(1) && grid[i,j + 1] == 0))
                        nTotalLength++;
                }
            }
        }

        return nTotalLength;
    }
}