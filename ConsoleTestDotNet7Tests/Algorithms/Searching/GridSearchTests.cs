using ConsoleTestDotNet7.Algorithms.Searching;

namespace ConsoleTestDotNet7Tests.Algorithms.Searching
{
    public class GridSearchTests
    {
        [Fact]
        public void GridSearchTest()
        {
            bool[,] grid6x6 = new[,]
            {
                { false, false, false, false, false, false },
                { false, true,  false, false, false, false },
                { false, false, false, false, false, true  },
                { false, false, false, false, false, false },
                { false, false, false, true,  false, false },
                { false, false, false, false, false, false },
            };

            var result = new GridSearch().GetDistances(grid6x6, 2, 4);

            Assert.Equal(result, new List<Distance>
            {
                new Distance(new Point(1, 1), 4),
                new Distance(new Point(5, 2), 5),
                new Distance(new Point(3, 4), 1),
            });
        }
    }
}

