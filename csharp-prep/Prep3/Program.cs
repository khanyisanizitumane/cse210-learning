using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random magic number between 1 and 10
        Random random = new Random();
        int magicNumber = random.Next(1, 11);

        Console.WriteLine("Welcome to Guess My Number Game!");
        Console.WriteLine("I have chosen a magic number between 1 and 10.");
        
        // Initialize guess variable
        int guess;

        // Loop until the user guesses the correct number
        do
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());

            // Check if the guess is higher, lower, or correct
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}
