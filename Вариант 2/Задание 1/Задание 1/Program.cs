using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] coords = ReadFile();
            Write_File(Sort_Areas(Get_Area(coords)),coords);
        }
        static double[,] ReadFile()
        {
            byte i = 0, curr_coord;
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 2\Задание 1\Задание 1\input.txt";
            double[,] coord = new double[File.ReadAllLines(path).Length, 4];
            string tmp;
            StreamReader reader = new StreamReader(path);
            Console.WriteLine("Not sorted coords:");
            while (!reader.EndOfStream)
            {
                curr_coord=0;
                tmp = reader.ReadLine();
                Console.WriteLine(tmp);
                foreach(string str in tmp.Split(' '))
                {
                    coord[i, curr_coord] = Double.Parse(str);
                    curr_coord++;
                }
                i++;
            }
            reader.Close();
            return coord;
        }
        static Dictionary<double, byte> Get_Area(double[,] arr)
        {
            Dictionary<double, byte> areas = new Dictionary<double, byte> { };
            for (byte i = 0; i < arr.Length / 4; i++)
            {
                areas.Add(2 * (Math.Abs(arr[i, 3] - arr[i, 1]) + Math.Abs(arr[i, 2] - arr[i, 0])),i);
            }
            return areas;
        }
        static List<byte> Sort_Areas(Dictionary<double, byte> areas)
        {
            List<byte> lst = new List<byte> { };
            foreach (KeyValuePair<double, byte> el in areas.OrderByDescending(key => key.Key))
            {
                lst.Add(el.Value);
            }
            return lst;
        }
        static void Write_File(List<byte> indexes, double[,] coord)
        {
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 2\Задание 1\Задание 1\output.txt";
            StreamWriter writer = new StreamWriter(path);
            Console.WriteLine("\n\nSorted coords:");
            foreach(byte index in indexes)
            {
                Console.WriteLine("{0} {1} {2} {3}", coord[index, 0], coord[index, 1], coord[index, 2], coord[index, 3]);
                writer.WriteLine("{0} {1} {2} {3}", coord[index, 0], coord[index, 1], coord[index, 2], coord[index, 3]);
            }
            writer.Close();
        }
    }
}
