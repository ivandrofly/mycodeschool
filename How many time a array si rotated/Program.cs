using System;

namespace How_many_time_a_array_si_rotated
{
    class Program
    {
        static int FindRatationCount(int[] a, int n)
        {
            int low = 0, high = n - 1;
            while (low <= high)
            {
                // Sorted / 0 rotation times
                if (a[low] <= a[high])
                    return low; // case 1;

                // find pivot (privot property next and prev both are greater)
                int mid = (low + high) >> 1;

                // if mid is last index in the array we need to got to first element
                int next = (mid + 1) % n;
                // prevent negative number
                int pre = (mid + n - 1) % n;

                if (a[mid] <= a[next] && a[mid] <= a[pre]) // case 2
                    return mid;
                else if (a[mid] <= a[high]) // case 3
                    high = mid - 1;
                else if (a[mid] >= a[low]) // case 4
                    low = mid + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] a = { 15, 22, 23, 28, 31, 38, 5, 6, 8, 10, 12 }; // 11 elements
            int count = FindRatationCount(a, a.Length);
            Console.WriteLine("The array is rotated {0} times", count);
            Console.ReadLine();
        }
    }
}
