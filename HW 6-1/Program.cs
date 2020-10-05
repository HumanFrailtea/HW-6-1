using System;

namespace HW_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = new char[10] { 'x', 'g', 'z', 'd', 'b', 'n', 'f', 's', 'h', 'e' };
            char[] secondArray = new char[firstArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }

            Console.WriteLine(secondArray);
            Console.ReadLine();
        }
    }
}
