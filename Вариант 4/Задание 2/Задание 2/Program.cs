using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Play_1Player();
        }
        static void Play_2Players()
        {
            short num = 0;
            bool curr_player = false;
            while (num < 40)
            {
                Console.Clear();
                Console.WriteLine("Number: " + num);
                curr_player = !curr_player;
                if (curr_player)
                {
                    Console.Write("Player 1 turn: ");
                    num += Int16.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Player 2 turn: ");
                    num += Int16.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Player "+ (!curr_player ? "2" : "1") + " won!");
        }
        static void Play_1Player()
        {
            short num = 0;
            for(short i=1;  num != 40; i++)
            {
                Console.WriteLine("Turn number " + i);
                Console.WriteLine("-------------------");
                Console.Write("Your turn: ");
                num += Int16.Parse(Console.ReadLine());
                Console.WriteLine("Computer turn: " + (5-(num%5)));
                num += (short)(5 - num % 5);
                Console.WriteLine("Current sum: " + num);
                Console.WriteLine("-------------------");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Computer won!");
        }
    }
}
