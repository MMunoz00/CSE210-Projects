using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("The rules are simple, guess the magic number!");
        Console.WriteLine("");
        string play = "Y";
        int guesses = 0;
        int guess = 0;
        string input = "";
        int number = randomGenerator.Next(1,100);
        do {
            Console.Write("What is your guess?: ");
            input = Console.ReadLine();
            guess = int.Parse(input);
            guesses++;
            if (guess > number) {
                Console.WriteLine("Lower");
            }
            else if (guess < number) {
                Console.WriteLine("Higher");
            }
            else if (guess == number) {
                Console.WriteLine("Congrats! You guessed the magic number!");
                Console.WriteLine($"Number of guesses: {guesses}.");
                Console.Write("Would you like to play again? (Enter 'Y' or 'N'): ");
                play = Console.ReadLine();
                play = play.ToUpper();
                number = randomGenerator.Next(1,100);
                guesses = 0;
            }
        }  while (play == "Y");
        Console.WriteLine("Thanks for playing!");
    }
}