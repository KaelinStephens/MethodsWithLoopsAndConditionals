using System;

namespace MethodsExercise3
{
    class Program
    {
        static void WhatToDo(string command)
        {
            switch (command)
            {
                case "Count Back":
                    for (int i = 1000; i <= 1000 && i >= -1000; i--)
                    {
                        Console.WriteLine($"{i}");
                    }
                    break;


                case "Count by Threes":

                    for (int i = 0; i <= 999; i += 3)
                    {
                        Console.WriteLine($"{i}");
                    }
                    break;
                case "Equal?":

                    Console.WriteLine("Enter a number");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    int b = int.Parse(Console.ReadLine());
                    bool c = a == b;
                    if (c == true)
                    {
                        Console.WriteLine($"{a} and {b} are equivalent");
                    }
                    else
                    {
                        Console.WriteLine($"{a} and {b} are not equivalent");
                    }
                    break;
                case "Even or Odd":

                    Console.WriteLine("Enter a number");
                    int num = int.Parse(Console.ReadLine());
                    int remainder = num % 2;
                    if (remainder == 0)
                    {
                        Console.WriteLine($"{num} is Even");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is Odd");
                    }
                    break;
                case "Pos or Neg":

                    Console.WriteLine("Enter a number");
                    num = int.Parse(Console.ReadLine());

                    if (num >= 0)
                    {
                        Console.WriteLine($"{num} is Positive");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is Negative");
                    }
                    break;
                case "Voting Age":
                    Console.WriteLine("Enter your age");
                    int age = int.Parse(Console.ReadLine());

                    if (age > 17)
                    {
                        Console.WriteLine("You may vote!");
                    }
                    else
                    {
                        Console.WriteLine("Looks like you're too young this time!");
                    }
                    break;

            }
        } 
        static void MultiplicationTable(int multiNum)
        {
            var i = 0;
            do
            {
                int numToDisplay = multiNum * i++;
                Console.WriteLine($"{numToDisplay}");
            } while (i < 13);
        }
        static void WithinRange(int num)
        {
            if (num < 11 && num > -11)
            {
                Console.WriteLine($"{num} is within the accepted range of -10 to 10");
            }
            else
            {
                Console.WriteLine($"{num} is not within the accepted range of -10 to 10");
            }
        }
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter a command \n" +
                "" +
                "Count Back \n" +
                "Count by Threes \n" +
                "Equal? \n" +
                "Even or Odd \n" +
                "Pos or Neg \n" +
                "Voting Age");
            string command = Console.ReadLine();
            WhatToDo(command);

            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            WithinRange(num);

            Console.WriteLine("What number do you want to see a multiplication table for?");
            int multiNum = int.Parse(Console.ReadLine());
            MultiplicationTable(multiNum);

            
        }
    }
}
