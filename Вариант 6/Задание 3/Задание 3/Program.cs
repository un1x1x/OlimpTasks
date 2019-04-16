using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            short N;
            Console.Write("How much times need to bend the paper: ");
            N = System.Convert.ToInt16(Console.ReadLine());
            List<bool> vector = new List<bool> {};
            func(System.Convert.ToInt16(N - 1), vector, false);
        }
        static List<bool> func(short num, List<bool> vector, bool side)
        {
            if (num > 0)
            {
                vector = func(System.Convert.ToInt16(num - 1), vector, side);
                vector.Add(vector[0]);
                for(short i = System.Convert.ToInt16(vector.Count-2); i >= 0; i--)
                {
                    vector.Add(!vector[i]);
                }
                Console.WriteLine("Bend number "+ (num+1) + ": ");
                foreach (bool i in vector)
                {
                    Console.Write(i ? "R " : "L ");
                }
                Console.WriteLine();
                Console.WriteLine();
                return vector;
            }
            else
            {
                Console.WriteLine();
                vector.Add(side);
                Console.WriteLine("Bend number 1: ");
                foreach(bool i in vector)
                {
                    Console.Write(i ? "R " : "L ");
                }
                Console.WriteLine();
                Console.WriteLine();
                return vector;
            }
        }
    }
}
