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
            string arr = Get_Number();
            do
            {
                Console.Clear();
                Console.WriteLine("Your number: " + arr);
                Show_Menu();
                arr = Get_Answer(arr);
            } while (arr!="");
        }
        static void Show_Menu()
        {
            Console.WriteLine("Convert to: ");
            Console.WriteLine("1. Binary system (2)");
            Console.WriteLine("2. Octal system (8)");
            Console.WriteLine("3. Decimal system (10)");
            Console.WriteLine("4. Hex system (16)");
            Console.WriteLine("5. Close program");
            Console.Write("Your choice: ");
        }
        static string Get_Number()
        {
            Console.Write("Write your number (b- binary, q - octal, h - hex): ");
            string arr;
            arr = Console.ReadLine();
            return arr;
        }
        static int Get_Base(string arr)
        {
            switch (arr[arr.Length - 1])
            {
                case 'b':
                    return 2;
                case 'q':
                    return 8;
                case 'h':
                    return 16;
                default:
                    return 10;
            }
        }
        static string Get_Answer(string arr)
        {
            int num = System.Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    if (arr[arr.Length - 1] != 'b')
                    {
                        arr = Convert(Convert_ToDecimal(arr), 2)+"b";
                    }
                    Console.WriteLine(arr);
                    Console.ReadKey();
                    return arr;
                case 2:
                    if (arr[arr.Length - 1] != 'q')
                    {
                        arr = Convert(Convert_ToDecimal(arr), 8)+"q";
                    }
                    Console.WriteLine(arr);
                    Console.ReadKey();
                    return arr;
                case 3:
                    arr = Convert_ToDecimal(arr);
                    Console.WriteLine(arr);
                    Console.ReadKey();
                    return arr;
                case 4:
                    if (arr[arr.Length - 1] != 'h')
                    {
                        arr = Convert(Convert_ToDecimal(arr), 16) + "h";
                    }
                    Console.WriteLine(arr);
                    Console.ReadKey();
                    return arr;
                case 5:
                    return "";
                default:
                    return arr;
            }
        }
        static int Convert_Letter(char ch)
        {
            if (Char.IsLetter(ch))
            {
                return (int)(ch - 'A' + 10);
            }
            else
            {
                return System.Convert.ToInt32(Char.GetNumericValue(ch));
            }
        }
        static char Convert_Number(int num)
        {
            int i = 10;
            char ch = 'A';
            while(i<num)
            {
                ch++;
                i++;
            }
            return ch;
        }
        static string Convert_ToDecimal(string arr)
        {
            if (Char.IsDigit(arr[arr.Length - 1]))
            {
                return arr;
            }
            int num = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int tmp = Convert_Letter(arr[i]);
                num += System.Convert.ToInt32(tmp * Math.Pow(Get_Base(arr), arr.Length - 2 - i));
            }
            return num.ToString();
        }
        static string Convert(string arr, byte system)
        {
            string tmp = "";
            int num = Int32.Parse(arr);
            while (num > 0)
            {
                if (num % system > 9)
                {
                    tmp += Convert_Number((int)(num % system)).ToString();
                }
                else
                {
                    tmp += (num % system).ToString();
                }
                num = (int)((num - num % system) / system);
            }
            char[] array = tmp.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
