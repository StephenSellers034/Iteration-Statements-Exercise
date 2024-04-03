namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
     public static void PrintAll()
        {
            for (int i = 1000; i >= -1000; i--) 
            {
                Console.WriteLine($"{i}");
            }
            
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintAllBy3()
        {
            for(int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool EqualTo(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("Choose a number, even or odd.");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Please enter a number positive or negative");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput > 0)
            {
                Console.WriteLine("The Number is positive.");
            }
            else if (userInput < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("Positive number");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void WhatIsYourAge()
        {
            Console.WriteLine("How old are you?");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput > 18)
            {
                Console.WriteLine("You can vote.");
            }
            else if(userInput > 18)
            {
                Console.WriteLine("You can't vote");
            }
            else
            {
                Console.WriteLine("lucky you, just made voting age");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IsItInRange()
        {
            Console.WriteLine("Enter a random number to see if your guess is in range.");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("Number is in range");

            }
            else
            {
                Console.WriteLine("Number is OUT of range");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x 6 = {i*6}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintAll();
            PrintAllBy3();
            Console.WriteLine(EqualTo(9, 7));
            EvenOrOdd();
            PositiveOrNegative();
            WhatIsYourAge();
            IsItInRange();
            MultiplicationTable();
        }
    }
}
