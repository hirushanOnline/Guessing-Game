using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretword = "applejuice";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool outOfGuesses = false;
             
            while(guess != secretword && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Your Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else 
                {
                    outOfGuesses = true;
                }
            }
            if(outOfGuesses)
            {
                Console.Write("You are Wrong! Try Again.");
            }
            else
            {
                Console.WriteLine("You are Correct!");
            }
            
            Console.ReadLine();


        }
    }
}
