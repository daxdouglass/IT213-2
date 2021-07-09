using System;

namespace IT213_DouglassUnit2
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************

            //****Assignment 2 Section 1

            //*********************************************************


            Console.WriteLine("Please enter a whole number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another whole number: ");
            int secNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum == secNum)
            {
                Console.WriteLine(firstNum + " = " + secNum);
            }
            if (firstNum != secNum)
            {
                Console.WriteLine(firstNum + " <> " + secNum);
            }
            if (firstNum < secNum)
            {
                Console.WriteLine(firstNum + " < " + secNum);
            }
            if (firstNum > secNum)
            {
                Console.WriteLine(firstNum + " > " + secNum);
            }
            if (firstNum <= secNum)
            {
                Console.WriteLine(firstNum + " <= " + secNum);
            }
            if (firstNum >= secNum)
            {
                Console.WriteLine(firstNum + " >= " + secNum);
            }

        }
    }
}
