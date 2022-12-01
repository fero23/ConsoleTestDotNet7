namespace ConsoleTestDotNet7.Algorithms.Sorting
{
    public interface ISort<T> where T : IComparable
    {
        public T[] Sort(T[] sortableArray);

        public void Swap(T[] sortableArray, int i, int j)
        {
            var temporal = sortableArray[j];
            sortableArray[j] = sortableArray[i];
            sortableArray[i] = temporal;
        }
    }
}

