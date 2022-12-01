namespace ConsoleTestDotNet7.Algorithms.Searching
{
    public class BinarySearch<T> : ISearch<T> where T : IComparable
    {
        public int? Search(T[] searchableArray, T element)
        {
            return DoBinarySearch(searchableArray, element, 0, searchableArray.Length - 1);
        }

        private int? DoBinarySearch(T[] searchableArray, T element, int start, int end)
        {
            while (start <= end
                   && element.CompareTo(searchableArray[start]) >= 0
                   && element.CompareTo(searchableArray[end]) <= 0)
            {
                if (start == end)
                {
                    return element.CompareTo(searchableArray[start]) == 0 ? start : null;
                }

                int middle = (start + end) / 2;
                int compareResult = element.CompareTo(searchableArray[middle]);

                if (compareResult == 0)
                {
                    return middle;
                }
                else if (compareResult < 0)
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
            }
            return null;
        }
    }
}