using System;

namespace BinaryClass
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryConverter p = new BinaryConverter();
            Console.WriteLine("Binary Value of 4 = " + p.IntToBinaryString(4));
        }


    }

    public class BinaryConverter
    {
        public string IntToBinaryString(int number)
        {
            const int mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                binary = (number & mask) + binary;
                number = number >> 1;
            }
            return binary;
        }
    }
}
