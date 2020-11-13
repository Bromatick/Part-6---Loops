using System;
using System.Globalization;

namespace Part_6___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Prompter
            int minValue;
            int maxValue;
            int inbetween;
            Console.WriteLine("Please enter a minimum value");
            while (!Int32.TryParse(Console.ReadLine(), out minValue))
                Console.WriteLine("Invalid integer, try again.");
            Console.WriteLine("You entered " + minValue);

            Console.WriteLine("Please enter a maximum value");
            do
            {
                while (!Int32.TryParse(Console.ReadLine(), out maxValue))
                    Console.WriteLine("Invalid integer, try again.");
                Console.WriteLine("You entered " + maxValue);
                if (!(maxValue > minValue))
                {
                    Console.WriteLine("Please enter a value higher than the minimum value.");
                }
            }
            while (!(maxValue > minValue));

            Console.WriteLine($"Now please enter a number between {minValue} and {maxValue}.");

            do
            {
                while (!Int32.TryParse(Console.ReadLine(), out inbetween))
                    Console.WriteLine("Invalid integer, try again.");
                if (!(minValue <= inbetween) || !(maxValue >= inbetween))
                {
                    Console.WriteLine("Please enter a number inbetween the max and min value.");
                }
            }
            while (!(minValue < inbetween) || !(maxValue > inbetween));

            Console.WriteLine("Good Job!");
            Console.WriteLine();

            //2) Percent Passing
            int tests;
            double maxPoints;
            double points;
            double percentage;
            Console.WriteLine("Auto Passer");
            Console.WriteLine();
            Console.WriteLine("How many tests are there to check");
            int.TryParse(Console.ReadLine(), out tests);

            for (int i = 1; i <= tests; i++)
            {
                Console.WriteLine($"#{i} Please enter what the score is out of:");
                while (!Double.TryParse(Console.ReadLine(), out maxPoints))
                    Console.WriteLine("Invalid integer, try again.");

                Console.WriteLine($"The test is out of {maxPoints} points");

                do
                {
                    Console.WriteLine("Now enter the points scored:");
                    while (!Double.TryParse(Console.ReadLine(), out points))
                        Console.WriteLine("Invalid integer, try again.");
                    if (points > maxPoints)
                    {
                        Console.WriteLine($"Please enter a number lower than the total score.");
                    }
                    else
                    {
                        Console.WriteLine($"Scored {points} out of {maxPoints}.");
                        percentage = points / maxPoints * 100;
                        if (percentage >= 70)
                        {
                            Console.WriteLine($"The percentage score is {percentage}% and it is a pass.");
                        }
                        else
                        {
                            Console.WriteLine($"The percentage score is {percentage}% and it is a fail");
                        }
                    }
                    Console.WriteLine();
                }
                while (points > maxPoints);
            }
            Console.WriteLine();

            //3) Odd Sum
            int userNum;
            Console.WriteLine("Please enter an integer");
            do
            {
                while (!Int32.TryParse(Console.ReadLine(), out userNum))
                    Console.WriteLine("Invalid integer, try again.");
                if (userNum < 1)
                {
                    Console.WriteLine("Please enter a number higher than or equal to 1");
                }
            }
            while (userNum < 1) ;

            for (int j = 1; j <= userNum; j += 2)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();
            //4) Random Numbers
            Random randomNum = new Random();
            int minimumValue;
            int maximumValue;
            Console.WriteLine("Random Number Generator");
            Console.WriteLine("Please enter a minimum value.");
            int.TryParse(Console.ReadLine(), out minimumValue);
            Console.WriteLine("You entered " + minimumValue);
            Console.WriteLine("Now please enter the maximum value.");
            int.TryParse(Console.ReadLine(), out maximumValue);
            Console.WriteLine("You entered " + maximumValue);

            for (int k = 1; k <= 25; k++)
            {
                int randomGenerated = randomNum.Next(minimumValue, maximumValue + 1);
                Console.WriteLine(randomGenerated);
            }

        }
    }
}
