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
            char[] arr = Rand_Number();
            while (!Guess_Answer(arr))
            {

            }
        }
        static char[] Rand_Number()
        {
            char[] arr = new char[5];
            Random rand = new Random();
            arr[0] = System.Convert.ToChar(rand.Next(10).ToString());
            for (ushort i = 1; i < 5; i++)
            {
                arr[i] = System.Convert.ToChar((rand.Next(9) + 1).ToString());
            }
            return arr;
        }
        static bool Guess_Answer(char[] arr)
        {
            char[] answer = new char[10];
            short count_place = 0;
            short count_nums = 0;
            Console.Write("Make your guess: ");
            answer = Console.ReadLine().ToCharArray();
            if (answer.Count() != 5)
            {
                Console.WriteLine("Wrong input! Please write another number!");
                return false;
            }
            for (short i = 0; i <5; i++)
            {
                if (arr[i] == answer[i])
                {
                    count_place++;
                }
            }
            SortedSet<char> nums = new SortedSet<char> { arr[0], arr[1], arr[2], arr[3], arr[4] };
            foreach(char i in nums)
            {
                if (answer.Contains(i))
                {
                    count_nums++;
                }
            }
            if (count_place < 5)
            {
                Console.WriteLine("Nums on right place: " + count_place);
                Console.WriteLine("Right nums: " + count_nums);
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Congratulations! You won!");
                return true;
            }
        }
    }
}
