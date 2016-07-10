using System;

namespace mycodeschool_Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //4^2
            // 2D array
            //var twoDArray = new int[4, 4] { { 2, 4, 6, 8 }, { 5, 9, 12, 16 }, { 2, 11, 5, 9 }, { 3, 2, 1, 8 } };

            // Jagged Array
            var jaggedArray = new int[4][];

            jaggedArray[0] = new int[] { 2, 4, 6, 8 };
            jaggedArray[1] = new int[] { 5, 9, 12, 16 };
            jaggedArray[2] = new int[] { 2, 11, 5, 9 };
            jaggedArray[3] = new int[] { 3, 2, 1, 8 };

            PrinSpiral(jaggedArray, 4, 4);
            Console.ReadLine();
        }

        public static void PrinSpiral(int[][] jaggedArray, int rows, int colons)
        {
            int top = 0, back = rows - 1, left = 0, right = colons - 1;
            var dir = Direction.Right;


            var count = 0;
            while (top <= right && left <= back)
            {
                switch (dir)
                {
                    case Direction.Right: // --->
                        for (int i = left; i <= right; i++)
                            WriteToConsole(dir, jaggedArray[top][i]);
                        top++;
                        dir = Direction.Bottom; // 1
                        break;
                    case Direction.Bottom:
                        for (int i = top; i <= back; i++)
                            WriteToConsole(dir, jaggedArray[i][right]);
                        right--;
                        dir = Direction.Left; // 2
                        break;
                    case Direction.Left: // <---
                        for (int i = right; i >= left; i--)
                            WriteToConsole(dir, jaggedArray[back][i]); // back = rows-1;
                        back--;
                        dir = Direction.Up;
                        break;
                    case Direction.Up:
                        for (int i = back; i >= top; i--)
                            WriteToConsole(dir, jaggedArray[back][i]);
                        left++;
                        dir = Direction.Right;
                        break;
                }
                count = (count + 1) % 4;
                dir = (Direction)count;
            }
        }

        private static void WriteToConsole(Direction dir, int i)
        {
            Console.Write("{0}, {1} - ", dir, i);
        }

        enum Direction
        {
            Right = 0,
            Bottom = 1,
            Left = 2,
            Up = 3
        }
    }
}
