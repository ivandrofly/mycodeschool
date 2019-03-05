using System;

namespace Quick_sort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Array to be sorted.
            int[] a = new[] { 7, 2, 1, 6, 8, 5, 3, 4 };

            // Pass array, start-index and the end index.
            QuickSort(a, 0, a.Length - 1);

            // Print sorted array.
            for (int i = 0; i < 8; i++)
            {
                Console.Write(a[i]);
            }

            //var b = new[] { 2, 1, 6, 7 };
            //QuickSort(b, 0, 3);
            //// print sorted array
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write(b[i]);
            //}

            Console.ReadLine();
        }

        private static void QuickSort(int[] a, int start, int end)
        {
            // segment validation
            if (start >= end)
            {
                return;
            }

            // calling partition
            int partitionIndex = Partition(a, start, end);
            QuickSort(a, start, partitionIndex - 1);
            QuickSort(a, partitionIndex + 1, end);
        }

        private static int Partition(int[] a, int start, int end)
        {
            int pivot = a[end];
            // set partition index as start initially
            int partitionIndex = start;
            for (int i = start; i < end; i++)
            {
                if (a[i] < pivot)
                {
                    // Only swap if variable *i and partitinoIndex are different.
                    if (i != partitionIndex)
                    {
                        // swap if element is lesser than pivot
                        Swap(ref a[i], ref a[partitionIndex]);
                    }
                    partitionIndex += 1;
                }
            }
            // swap pivot with element at partition index
            Swap(ref a[partitionIndex], ref a[end]);
            return partitionIndex;
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
