/// Homework No.__ Exercise No.__
/// File Name:     HW 6-1.sln
/// @author:       Student Name (First Last)
/// Date:          Sept. 1, 2015
///
/// Problem Statement: (what you want the code to do)
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create first array.
/// 2. Create second array.
/// 3. Run for loop and insert values from first array into second array.
/// 4. Write out the entries of the 2nd array.
/// etc.

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
