using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            short N;
            Console.Write("How much times need to bend the paper: ");
            N = System.Convert.ToInt16(Console.ReadLine());
            List<bool> vector = new List<bool> { };
            foreach(bool i in func(Find_Iterations(N), vector, false))
            {
                Console.Write(i ? "R " : "L ");
                N--;
                if (N == 0)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        static List<bool> func(short num, List<bool> vector, bool side)
        {
            if (num > 0)
            {
                vector = func(System.Convert.ToInt16(num - 1), vector, side);
                vector.Add(vector[0]);
                for (short i = System.Convert.ToInt16(vector.Count - 2); i >= 0; i--)
                {
                    vector.Add(!vector[i]);
                }
                return vector;
            }
            else
            {
                vector.Add(side);
                return vector;
            }
        }
        static short Find_Iterations(short N)
        {
            short count = 0;
            while (N > 1)
            {
                if (N % 2 != 0)
                {
                    N = System.Convert.ToInt16((N - 1) / 2);
                }
                else
                {
                    N = System.Convert.ToInt16(N / 2);
                }
                count++;
            }
            return count;
        }
    }
}
