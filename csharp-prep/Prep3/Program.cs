using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number?");
        // string magic = Console.ReadLine();
        // int number = int.Parse(magic);
        // Console.WriteLine("What is your guess?");
         string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,101);
        int number = -1;
        if (number > userGuess)
            {
                Console.WriteLine("Higher");
            }
        else if (number < userGuess)
            {
                Console.WriteLine("Lower"); ;
            }
        else 
            {
                Console.WriteLine("You Guessed it!");                    
            }
    }
}
