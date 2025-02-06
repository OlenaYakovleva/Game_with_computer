using System;
using static System.Console;

namespace Program
{
    namespace Game
    {
        public class Game
        {
            public int Min_num { get; set; }
            public int Max_num { get; set; }
            public int Guess { get; set; }
            public int Count { get; set; }
            public int Result { get; set; }

            // Constructor
            public Game()
            {
                Min_num = 1; // Set the default value for Min
                Max_num = 20; // Set the default value for max
                Guess = 0;
                Count = 0;
                Result = 0;
            }

            public void Start()
            {
                WriteLine($"Let us start the game. I will guess your number between {Min_num} and {Max_num}. Think of a number now.");

                // Binary search
                while (Min_num <= Max_num)
                {
                    Guess = (Min_num + Max_num) / 2; // Middle of the range
                    Count++;
                    WriteLine($"My guess is {Guess}. If correct answer with 'yes', if higher write 'higher', if lower write 'lower'");

                    string answer = ReadLine().ToLower();
                    if (answer == "higher")
                    {
                        Min_num = Guess + 1; 
                    }
                    else if (answer == "lower")
                    {
                        Max_num = Guess - 1; 
                    }
                    else if (answer == "yes")
                    {
                        Result = Guess; 
                        WriteLine($"It is correct! This many guesses - {Count} - I need to win");
                        break;
                    }
                    else
                    {
                        WriteLine("Please respond with 'higher', 'lower', or 'yes'.");
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            var game = new Game.Game(); 
            game.Start(); 
        }
    }
}