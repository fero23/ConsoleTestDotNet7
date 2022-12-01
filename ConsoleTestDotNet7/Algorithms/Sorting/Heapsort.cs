using System;
namespace ConsoleTestDotNet7.Algorithms.Sorting
{
    public class Heapsort<T> : ISort<T> where T : IComparable
    {
        public T[] Sort(T[] sortableArray)
        {
            DoHeapsort(sortableArray);
            return sortableArray;
        }

        private void Heapify(T[] sortableArray, int heapSize, int parentIndex)
        {
            int larger = parentIndex;
            int leftChildIndex = parentIndex * 2 + 1;
            int rightChildIndex = parentIndex * 2 + 2;

            if (leftChildIndex < heapSize && sortableArray[leftChildIndex].CompareTo(sortableArray[larger]) > 0)
            {
                larger = leftChildIndex;
            }

            if (rightChildIndex < heapSize && sortableArray[rightChildIndex].CompareTo(sortableArray[larger]) > 0)
            {
                larger = rightChildIndex;
            }

            if (larger != parentIndex)
            {
                ((ISort<T>)this).Swap(sortableArray, parentIndex, larger);
                Heapify(sortableArray, heapSize, larger);
            }
        }

        private void DoHeapsort(T[] sortableArray)
        {
            // create max heap for all non-lead indexes
            for (int parentNode = sortableArray.Length / 2 - 1; parentNode >= 0; --parentNode)
            {
                Heapify(sortableArray, sortableArray.Length, parentNode);
            }

            for (int lastNode = sortableArray.Length - 1; lastNode >= 1; --lastNode)
            {
                ((ISort<T>)this).Swap(sortableArray, lastNode, 0);
                Heapify(sortableArray, lastNode, 0);
            }
        }
    }
}

