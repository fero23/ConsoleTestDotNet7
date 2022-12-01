namespace ConsoleTestDotNet7.Algorithms.Sorting
{
    public class Quicksort<T> : ISort<T> where T : IComparable
    {
        public T[] Sort(T[] sortableArray)
        {
            return DoQuicksort(sortableArray, 0, sortableArray.Length - 1);
        }

        private T[] DoQuicksort(T[] sortableArray, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(sortableArray, start, end);
                DoQuicksort(sortableArray, start, pivot - 1);
                DoQuicksort(sortableArray, pivot + 1, end);
            }
            return sortableArray;
        }

        private int Partition(T[] sortableArray, int start, int end)
        {
            var pivot = sortableArray[end];
            var i = start - 1; // keeps track of the index last element that whose value is less than the pivot
            for (var j = start; j <= end - 1; ++j)
            {
                if (sortableArray[j].CompareTo(pivot) < 0)
                {
                    ++i;
                    ((ISort<T>)this).Swap(sortableArray, i, j);
                }
            }
            ((ISort<T>)this).Swap(sortableArray, i + 1, end);
            return i + 1;
        }
    }
}