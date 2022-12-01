namespace ConsoleTestDotNet7.Algorithms.Searching
{
    public interface ISearch<T> where T : IComparable
    {
        public int? Search(T[] searchableArray, T element);
    }
}

