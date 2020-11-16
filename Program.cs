using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the secret number?");
            Guess();
        }
        static void Guess()
        {
            string guess = Console.ReadLine();
        }
    }
}
