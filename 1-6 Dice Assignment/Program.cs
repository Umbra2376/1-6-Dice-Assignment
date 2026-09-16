using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace _1_6_Dice_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            double bet, wallet = 100;
            int guess;
            bool done = false;
            die1 = new Die();
            die2 = new Die();
            while (!done)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome to the Dice Game!");
                Console.WriteLine("You will have a starting bet of $100.  You will be asked to guess if the dice result is:");
                Console.WriteLine("1.  Doubles(win double your bet");
                Console.WriteLine("2.  Not Doubles(win half your bet)");
                Console.WriteLine("3.  Even SUM(win your bet)");
                Console.WriteLine("4.  Odd SUM(win your bet)");
                Console.WriteLine("Any invalid response or incorrect guess will result in you losing your bet so type carefully.");
                Console.WriteLine("You have $" + wallet + " in your wallet.");
                Console.WriteLine("What color would you like Die 1 to be? (Red, Green, Blue, Yellow, Magenta, Cyan)");
                die1.Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine(), true);
                Console.WriteLine("What color would you like Die 2 to be? (Red, Green, Blue, Yellow, Magenta, Cyan)");
                die2.Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine(), true);
                Console.WriteLine("How much would you like to bet?");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out bet) || bet > wallet || bet < 0)
                {
                    Console.WriteLine("This is an invalid bet.");
                    Console.WriteLine("Press any ENTER to continue...");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("What is your guess? (1-4)");
                string answer = Console.ReadLine();
                Random rand = new Random();
                die1.RollDie();
                die2.RollDie();
                die1.DrawRoll();
                die2.DrawRoll();
                if (!int.TryParse(answer, out guess) || guess == 1 && die1.Roll == die2.Roll)
                {
                    wallet += bet * 2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You guessed doubles and won $" + (bet*2) + "! You now have $" + wallet);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (guess == 2 && die1.Roll != die2.Roll)
                {
                    wallet += bet / 2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You guessed not doubles and won $" + (bet/2) + "! You now have $" + wallet);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (guess == 3 && (die1.Roll + die2.Roll) % 2 == 0)
                {
                    wallet += bet;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You guessed even sum and won $" + bet + "! You now have $" + wallet);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (guess == 4 && (die1.Roll + die2.Roll) % 2 != 0)
                {
                    wallet += bet;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You guessed odd sum and won $" + bet + "! You now have $" + wallet);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    wallet -= bet;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You guessed incorrectly or made an invalid bet and lost $" + bet + ". You now have $" + wallet);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                Console.WriteLine("Would you like to play? (Y/N)");
                string response = Console.ReadLine();
                if (response.ToUpper() == "N")
                {
                    done = true;
                    break;
                }
                else if (response.ToUpper() != "Y")
                {
                    continue;
                }
            }
        }
    }
}