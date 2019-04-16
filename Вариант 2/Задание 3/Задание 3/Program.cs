using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_3
{
    class Program
    {
        public static class Globals
        {
            public static readonly short SIZE = ReadFile();
            public static bool[,] board = new bool[SIZE, SIZE];
            public static int results = 0;
            public static StreamWriter writer = new StreamWriter(@"C:\Users\DENYS\Desktop\Олимпиада\Вариант 2\Задание 3\Задание 3\output.txt", append: false);
        }
        static void Main(string[] args)
        {
            Set_queen(0);
            Console.WriteLine("PROGRAM FINISHED!");
            Console.WriteLine("Total results: " + Globals.results);
            Globals.writer.Close();
        }
        static void Set_queen(short row)
        {
            if(row == Globals.SIZE)
            {
                WriteFile();
                Globals.results++;
                return;
            }
            for(short i = 0; i < Globals.SIZE; ++i)
            {
                if (Check_queen(row, i))
                {
                    Globals.board[row, i] = true;
                    Set_queen(System.Convert.ToInt16(row + 1));
                    Globals.board[row, i] = false;
                }
            }
            return;

        }
        static bool Check_queen(short row, short col)
        {
            for (short i = 0; i < row; i++)
            {
                if (Globals.board[i, col])
                {
                    return false;
                }
            }
            for (short i = 1; i <= row && col - i >= 0; ++i)
            {
                if (Globals.board[row - i, col - i])
                {
                    return false;
                }
            }
            for (short i = 1; i <= row && col + i < Globals.SIZE; i++)
            {
                if (Globals.board[row - i, col + i])
                {
                    return false;
                }
            }
            return true;
        }
        static short ReadFile()
        {
            short num;
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 2\Задание 3\Задание 3\input.txt";
            FileStream file = new FileStream(path,FileMode.Open);
            StreamReader reader = new StreamReader(file);
            num = Int16.Parse(reader.ReadLine());
            reader.Close();
            file.Close();
            return num;
        }
        static void WriteFile()
        {
            for (short row = 0; row < Globals.SIZE; row++)
            {
                for (short col = 0; col < Globals.SIZE; col++)
                {
                    if (Globals.board[row, col] == true)
                    {
                        Globals.writer.Write(col + 1 + " ");
                    }
                }
            }
            Globals.writer.WriteLine();
        }
    }
}
