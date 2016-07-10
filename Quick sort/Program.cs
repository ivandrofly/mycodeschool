using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 7, 2, 1, 6, 8, 5, 3, 4 };
            QuickSort(a, 0, 7);
            // print sorted array
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
            if (start >= end)
                return;

            // calling partition
            int partitionIndex = Partition(a, start, end);
            QuickSort(a, start, partitionIndex - 1);
            QuickSort(a, partitionIndex + 1, end);
        }

        private static int Partition(int[] a, int start, int end)
        {
            var pivot = a[end];
            // set partition index as start initially
            var partitionIndex = start;
            for (int i = start; i < end; i++)
            {
                if (a[i] < pivot)
                {
                    // swap if element is lesser than pivot
                    Swap(ref a[i], ref a[partitionIndex]);
                    partitionIndex += 1;
                }
            }
            // swap pivot with element at partition index
            Swap(ref a[partitionIndex], ref a[end]);
            return partitionIndex;
        }

        private static void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }
}
