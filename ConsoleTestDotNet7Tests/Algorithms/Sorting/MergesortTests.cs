using ConsoleTestDotNet7.Algorithms.Sorting;

namespace ConsoleTestDotNet7Tests.Algorithms.Sorting
{
	public class MergesortTests
	{
        [Fact]
        public void SortArrayTest()
        {
            var array = new[] { 10, 80, 30, 90, 40, 50, 70 };
            new Mergesort<int>().Sort(array);
            Assert.Equal(new[] { 10, 30, 40, 50, 70, 80, 90 }, array);
        }

        [Fact]
        public void SortRandomArrayTest()
        {
            var faker = new Faker();
            var array = Enumerable.Range(1, 100000).Select(_ => faker.Random.Long()).ToArray();
            var arrayCopy = array.ToArray();
            new Mergesort<long>().Sort(array);
            Array.Sort(arrayCopy);
            Assert.Equal(arrayCopy, array);
        }
    }
}

