using System;

namespace Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 1024;
            DecimalToBinary(8);
        }

        static void DecimalToBinary(int n)
        {
            var logResult = (int)Math.Log(n, 2);
            var array = new int[logResult + 1];
            var idx = array.Length - 1; // no reverse needed ;)
            while (n > 0)
            {
                var rem = n % 2;
                array[idx] = rem;
                n /= 2;
                idx--;
            }

            // Test
            var bytes = new byte[] { 255, 128, 192 };
            Console.WriteLine(BitConverter.ToString(bytes, 0)); // convert then to hext
            // int.Parse("3A",NumberStyles.HexNumber)
            Convert.ToInt32("3A", 16);


            Console.Read();

            //Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.ReadLine();
        }
    }
}
