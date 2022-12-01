using System;
using ConsoleTestDotNet7.Algorithms.Searching;

namespace ConsoleTestDotNet7Tests.Algorithms.Searching
{
    public class BinarySearchTests
    {
        [Fact]
        public void SearchAllElementsTest()
        {
            Faker faker = new();
            var array = Enumerable
                .Range(0, 1000)
                .Select(_ => faker.Random.Long())
                .ToArray();

            Array.Sort(array);

            BinarySearch<long> searcher = new();
            foreach (int index in Enumerable.Range(0, array.Length))
            {
                int? searchResult = searcher.Search(array, array[index]);
                Assert.Equal(index, searchResult);
            }
        }
    }
}

