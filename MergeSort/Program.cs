using System;

namespace MergeSortAlgorithm
{
    internal class Program
    {
        private static void MergeSort(int[] a)
        {
            if (a.Length < 2)
            {
                return;
            }

            // Split in middle
            int mid = a.Length >> 1;

            int[] left = new int[mid];
            int[] right = new int[a.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = a[i];
            }

            for (int i = mid; i < a.Length; i++)
            {
                right[i - mid] = a[i];
            }

            MergeSort(left);
            MergeSort(right);

            Merge(left, right, a);
        }

        private static void Merge(int[] left, int[] right, int[] a)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    a[k] = left[i++];
                }
                else
                {
                    a[k] = right[j++];
                }

                k++;
            }
            while (i < left.Length)
            {
                a[k] = left[i++];
                k++;
            }
            while (j < right.Length)
            {
                a[k] = right[j++];
                k++;
            }
        }

        private static void Main(string[] args)
        {
            int[] list = { 2, 4, 1, 6, 8, 5, 3, 7 };
            Console.WriteLine("Before performing merge-sort");
            PrintArray(list);
            MergeSort(list);
            Console.WriteLine("After sort");
            PrintArray(list);
            Console.ReadLine();
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
