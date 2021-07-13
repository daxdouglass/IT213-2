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


            Console.Write("Please enter a whole number: ");             
            int firstNum = Convert.ToInt32(Console.ReadLine());             // Convert first number to int

            Console.Write("Please enter another whole number: ");
            int secNum = Convert.ToInt32(Console.ReadLine());               // Convert second number to int

            // Begin comparisons of first and second numbers

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

            //*********************************************************

            //****Assignment 2 Section 2

            //*********************************************************

            Console.WriteLine(" ");
            Console.Write("Please enter a numerical grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());                //Convert grade to an int

            if (grade >= 60)                                                // Check if grade equal to or greater than 60
            { 
                Console.WriteLine("Congratulations, you passed."); 
            }
            else
            {
                Console.WriteLine("Sorry, you failed.");
            }

            //*********************************************************

            //****Assignment 2 Section 3

            //*********************************************************

            Console.WriteLine(" ");
            Console.Write("Please enter a month in numerical format (1 - 12): ");
            int month = Convert.ToInt32(Console.ReadLine());                //Convert month to an int

            // Determine the name of the month entered

            if (month == 1)                                                
            {
                Console.WriteLine("You entered January.");
            }
            else if (month == 2)
            {
                Console.WriteLine("You entered February.");
            }
            else if (month == 3)
            {
                Console.WriteLine("You entered March.");
            }
            else if (month == 4)
            {
                Console.WriteLine("You entered April.");
            }
            else if (month == 5)
            {
                Console.WriteLine("You entered May.");
            }
            else if (month == 6)
            {
                Console.WriteLine("You entered June.");
            }
            else if (month == 7)
            {
                Console.WriteLine("You entered July.");
            }
            else if (month == 8)
            {
                Console.WriteLine("You entered August.");
            }
            else if (month == 9)
            {
                Console.WriteLine("You entered September.");
            } 
            else if (month == 10)
            {
                Console.WriteLine("You entered October.");
            }
            else if (month == 11)
            {
                Console.WriteLine("You entered November.");
            }
            else if (month == 12)
            {
                Console.WriteLine("You entered December.");
            }
            else
            { 
                Console.WriteLine("You entered an invalid number");
            }

            //*********************************************************

            //****Assignment 2 Section 4

            //*********************************************************

            Console.WriteLine(" ");
            Console.Write("Please enter a day of the week in numerical format (1 - 7): ");
            int weekDay = Convert.ToInt32(Console.ReadLine());                //Convert week day to an int

            // Determine the name of the day of week

            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:                                                            // User entered an invalid day of the week
                    Console.WriteLine("You entered an invalid day of the week.");
                    break;
            }

        }

    }
}
