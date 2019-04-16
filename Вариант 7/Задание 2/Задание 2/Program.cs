using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Get_Angle(Convert_ToDegrees(Read_File()));
            Console.WriteLine("Result: "+ num);
            Write_File(num);
        }
        static short[] Read_File()
        {
            string[] arr = new string[2];
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 7\Задание 2\Задание 2\input.txt";
            StreamReader reader = new StreamReader(path);
            arr = reader.ReadLine().Split(':');
            short[] result = new short[2] { Int16.Parse(arr[0]), Int16.Parse(arr[1]) };
            reader.Close();
            return result;
        }
        static short[] Convert_ToDegrees(short[] arr)
        {
            arr[0] = (short)(arr[0] * 5 * 6);
            arr[0] += (short)(arr[1] / 12 * 6);
            arr[1] = (short)(arr[1]*6);
            return arr;
        }
        static double Get_Angle(short[] arr)
        {
            double num = Math.Abs(arr[0] - arr[1]);
            return Math.Abs(Math.Min(num, 360.0 - num));
        }
        static void Write_File(double num)
        {
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 7\Задание 2\Задание 2\output.txt";
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(num);
            writer.Close();
            return;
        }
    }
}
