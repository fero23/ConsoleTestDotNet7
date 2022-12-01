namespace ConsoleTestDotNet7.Algorithms.Searching
{
    public record Point(int X, int Y);

    public record Distance(Point Person, int Length);

    public class GridSearch
    {
        public List<Distance> GetDistances(bool[,] grid, int x, int y)
        {
            List<Distance> distances = new();

            for (int posY = 0; posY < grid.GetLength(0); ++posY)
            {
                for (int posX = 0; posX < grid.GetLength(1); ++posX)
                {
                    if (grid[posY, posX])
                    {
                        int distance = CalculateDistance(posX, posY, x, y);
                        distances.Add(new Distance(new Point(posX, posY), distance));
                    }
                }
            }

            return distances;
        }

        private int CalculateDistance(int posX, int posY, int x, int y)
        {
            int distance = 0;

            while (posX < x)
            {
                ++distance;
                ++posX;
            }

            while (posX > x)
            {
                ++distance;
                --posX;
            }

            while (posY < y)
            {
                ++distance;
                ++posY;
            }

            while (posY > y)
            {
                ++distance;
                --posY;
            }

            return distance;
        }
    }
}

