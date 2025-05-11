using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        numbers.Sort();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number. ('0' when finished): ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber!= 0)
            {
                numbers.Add(userNumber);
            }
         }
       
       // Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}.");

        //Average.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is {average}.");

        // Finding the highest number.
        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is {max}.");
        
        int min = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }
        

        Console.WriteLine($"The smallest positive number is {min}.");

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        

    }
}