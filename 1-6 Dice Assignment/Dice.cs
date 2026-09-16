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
        ConsoleColor _color;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
            _color = ConsoleColor.White;
        }

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
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
            ConsoleColor _currentForecolor = Console.ForegroundColor;
            Console.ForegroundColor = _color;
            if (_roll == 1)
            {
                Console.WriteLine("┌───────┐");
                Console.WriteLine("|       |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("|       |");
                Console.WriteLine("└───────┘");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|    O  |");
                Console.WriteLine("└───────┘");
            }

            else if (_roll == 3)
            {
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O     |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("|     O |");
                Console.WriteLine("└───────┘");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O   O |");
                Console.WriteLine("|       |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("└───────┘");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O   O |");
                Console.WriteLine("|   O   |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("└───────┘");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("┌───────┐");
                Console.WriteLine("| O   O |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("| O   O |");
                Console.WriteLine("└───────┘");
            }
            Console.ForegroundColor = _currentForecolor;
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

    }
}