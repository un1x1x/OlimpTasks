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
            Console.Write("Number system (2-10): ");
            short syst = Convert.ToInt16(Console.ReadLine());
            Console.Write("Convert to system (2-10): ");
            short syst_new = Convert.ToInt16(Console.ReadLine());
            int num = Get_Number();
            if(syst_new == 10)
            {
                Console.WriteLine("Result: "+ To_Decimal(num, syst));
            }
            else
            {
                Console.WriteLine("Result: "+ To_System(To_Decimal(num, syst), syst_new));
            }
        }
        static int Get_Number()
        {
            Console.WriteLine("Write your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        static int To_Decimal(int num, short syst)
        {
            if (syst == 10)
            {
                return num;
            }
            int tmp = 0;
            for(byte i=0; num > 0;i++)
            {
                tmp += (int)(num % 10 * Math.Pow(syst, i));
                num = (num - (num % 10)) / 10;
            }
            return tmp;
        }
        static string To_System(int num, short syst)
        {
            string tmp = "";
            while (num > 0)
            {
                tmp += (num % syst).ToString();
                num = (num - num % syst) / syst;
            }
            char[] arr = tmp.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
