using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_that_number
{
    class Program
    {
        static void Main(string[] args)
        {
            guessthatNumber();
            Console.ReadKey();
        }
        static void guessthatNumber()
        {
        string name; // naming yourself
        Console.Write("Hello player, my name is guess, what is your name?");
        name = Console.ReadLine();
        Console.Write("Ok " + name + " let's start by telling you why your here shall we. press enter to continue.");
        Console.ReadLine();// to type your own words.
        Console.Write("You are here because you wanted to thats why, now time for the game, you must type the number, from 1 to 100, to guess the number I hve picked from the top of my head. got it, press enter again to confirm.");
        Console.ReadLine();
        Console.Write("Ok, then let's begging. keep pressing enter tell you actully get to the game.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("         GUESS THAT NUMBER             ");
        Console.ReadLine();
        Random rng = new Random();// so I can think of a number (from 1 to 100) I can torment you with.
        int randomNumber = rng.Next(1, 101);
        int playernumber;// to see if the number you choose was right.
        int count = 0;// so I can tell yo how many times you failed.
        Console.WriteLine("time to guess your number");// so you know when it's your turn.
        playernumber = int.Parse(Console.ReadLine());// turns this to a string.
        Console.WriteLine();
        while (randomNumber != playernumber)
        {
            if (playernumber > 100 || playernumber < 0)//If you were thinking  that 764 was the number.
            {
                Console.WriteLine("In the game of guessing a number between 1 and 100, you can guess only to 1 to 100. lets try again shall we.");
                playernumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                count++;
            }
            else if (playernumber < randomNumber)
            {
                Console.Write("your number is smaller then the number I guessed, try again.");//If you pick a number smaller then mine.
                playernumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                count++;
            }
            else
            {
                Console.Write("The number you guessed was higher then intended. Let's try again shall we.");// If you picked a number bigger then mine
                playernumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                count++;
            }
        }
        if (randomNumber == playernumber)
        {
            Console.WriteLine("congratulations you won, finally.");
            Console.WriteLine("the number I picked was " + randomNumber + ".");
            Console.WriteLine("and  you gussed about " + (count+1) + " times");
        }
       /* string answer;
        Console.Write("Do you want to play again sir?");
        answer = Console.ReadLine().ToUpper();
        while (answer == Y)
        {
            guessthatNumber();
            Console.Write("Do you want to play again sir?");
            answer = Console.ReadLine().ToUpper();
        }
        Console.WriteLine("Then good day sir.");//end game
        Console.WriteLine("Press any key you have to go."); */
        }
    }
}
