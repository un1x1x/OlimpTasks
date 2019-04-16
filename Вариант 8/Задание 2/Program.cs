using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, mins;
            Console.WriteLine("Input hours: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input minutes: ");
            mins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стрелки совпадут через " + Compute(hours, mins) + " минут");
        }
        static uint Compute(int h, int m)
        {
            uint counter = 0;
            if (h == 12 && m == 0)
                return 0;
            while (h * 5 + Convert.ToInt32(m / 12) != m)
            {
                if (m == 60)
                { m = 0; h++; }
                m++;
                counter++;
            }
            return counter;
        }
       
        
    }
}
