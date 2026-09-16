using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6_Dice_Assignment
{
    public class Die
    {
        private int _roll;
        private static Random _generator;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }


        public int Roll
        {
            get { return _roll; }
        }

        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;
        }

        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("┌───────┐");
                Console.WriteLine("|       |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("|       |");
                Console.WriteLine("└───────┘");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|    O  |");
                Console.WriteLine("└───────┘");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (_roll == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O     |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("|     O |");
                Console.WriteLine("└───────┘");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O   O |");
                Console.WriteLine("|       |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("└───────┘");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O   O |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("└───────┘");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 6)
            {
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O   O |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("└───────┘");
            }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

    }
}