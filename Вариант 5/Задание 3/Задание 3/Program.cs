using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many robots exists in start (at least 3): ");
            int k = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("How many years robots work: ");
            short years = System.Convert.ToInt16(Console.ReadLine());
            List<int> robots = new List<int> { k };
            solve(robots, years);
        }
        static int solve(List<int> robots, short years)
        {
            for(short i = 1; i <= years; i++)
            {
                if (robots[robots.Count - 1] % 5 == 0)
                {
                    robots.Add(robots[robots.Count-1]+(robots[robots.Count - 1] / 5 * 9));
                }
                else
                {
                    short count = 0;
                    robots.Add(robots[robots.Count - 1]);
                    while (robots[robots.Count - 1] % 5 != 0)
                    {
                        robots[robots.Count - 1] -= 3;
                        if(robots[robots.Count - 1] <= 0)
                        {
                            break;
                        }
                        count++;
                    }
                    robots[robots.Count - 1] = robots[robots.Count-2]+(robots[robots.Count - 1] / 5 * 9 + count * 5);
                }
                if (i > 2)
                {
                    robots[robots.Count - 1] -= robots[robots.Count - 4];
                }
                Console.WriteLine(robots[robots.Count - 1]);
            }
            return 1;
        }
    }
}
