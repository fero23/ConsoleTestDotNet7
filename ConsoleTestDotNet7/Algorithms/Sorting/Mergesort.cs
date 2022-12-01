using System;
namespace ConsoleTestDotNet7.Algorithms.Sorting
{
    public class Mergesort<T> : ISort<T> where T : IComparable
    {
        public T[] Sort(T[] sortableArray)
        {
            DoMergeSort(sortableArray, 0, sortableArray.Length - 1);
            return sortableArray;
        }

        private void DoMergeSort(T[] sortableArray, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                DoMergeSort(sortableArray, start, middle);
                DoMergeSort(sortableArray, middle + 1, end);
                Merge(sortableArray, start, middle, end);
            }
        }

        private void Merge(T[] sortableArray, int start, int middle, int end)
        {
            List<T> result = new(end - start);
            int i = start;
            int j = middle + 1;

            while (i <= middle && j <= end)
            {
                if (sortableArray[i].CompareTo(sortableArray[j]) < 0)
                {
                    result.Add(sortableArray[i]);
                    ++i;
                }
                else
                {
                    result.Add(sortableArray[j]);
                    ++j;
                }
            }

            while (i <= middle)
            {
                result.Add(sortableArray[i]);
                ++i;
            }

            while (j <= end)
            {
                result.Add(sortableArray[j]);
                ++j;
            }

            for (int a = start, b = 0; a <= end; ++a, ++b)
            {
                sortableArray[a] = result[b];
            }
        }
    }
}

