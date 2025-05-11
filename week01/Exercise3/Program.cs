using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int count = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Guess a higher number!");
                
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess a lower number!");
            }
            else
            {
                Console.WriteLine("'You guessed it right!");
                Console.WriteLine($"It took you {count} guesses.");
            }
        }


    }

}    



   