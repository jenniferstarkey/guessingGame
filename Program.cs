using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("---------------------------");
            Greeting();

            Console.WriteLine("What's the secret number?");

            int SecretNumber = 45;
            int userTries = 0;
            int maxTries = 3;

            string guess = Console.ReadLine();
            int userGuess = int.Parse(guess);
            // Console.WriteLine($"Your guess is {userGuess}");
            while (userGuess != SecretNumber && userTries < maxTries)
            {
                Console.WriteLine("That's not it, bro.");
                guess = Console.ReadLine();

                if (userGuess == SecretNumber)
                {
                    Console.WriteLine("You got it!");
                }
                else
                {
                    userTries++;
                    if (userTries == 3)
                    {
                        Console.WriteLine("Try again when you're feeling more lucky.");
                    }
                }
            }



        }
        static void Greeting()
        {
            Console.WriteLine($@"
            ─────────────────────────────▄██▄
            ─────────────────────────────▀███
            ────────────────────────────────█
            ───────────────▄▄▄▄▄────────────█
            ──────────────▀▄────▀▄──────────█
            ──────────▄▀▀▀▄─█▄▄▄▄█▄▄─▄▀▀▀▄──█
            ─────────█──▄──█────────█───▄─█─█
            ─────────▀▄───▄▀────────▀▄───▄▀─█
            ──────────█▀▀▀────────────▀▀▀─█─█
            ──────────█───────────────────█─█
            ▄▀▄▄▀▄────█──▄█▀█▀█▀█▀█▀█▄────█─█
            █▒▒▒▒█────█──█████████████▄───█─█
            █▒▒▒▒█────█──██████████████▄──█─█
            █▒▒▒▒█────█───██████████████▄─█─█
            █▒▒▒▒█────█────██████████████─█─█
            █▒▒▒▒█────█───██████████████▀─█─█
            █▒▒▒▒█───██───██████████████──█─█
            ▀████▀──██▀█──█████████████▀──█▄█
            ──██───██──▀█──█▄█▄█▄█▄█▄█▀──▄█▀
            ──██──██────▀█─────────────▄▀▓█
            ──██─██──────▀█▀▄▄▄▄▄▄▄▄▄▀▀▓▓▓█
            ──████────────█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
            ──███─────────█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
            ──██──────────█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
            ──██──────────█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
            ──██─────────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
            ──██────────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
            ──██───────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌
            ──██──────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌
            ──██─────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌
            ──██────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌


        ");
        }
    }
}
