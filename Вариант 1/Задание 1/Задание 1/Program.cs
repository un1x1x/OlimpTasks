using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = ReadFromFile();
            Console.Write("Operation: ");
            Console.WriteLine(text);
            Console.Write("Result: ");
            Console.WriteLine(Get_Result(text));
            Write_File(text);
        }
        static string ReadFromFile()
        {
            string text;
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 1\Задание 1\Задание 1\input.txt";
            FileStream file = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            text = reader.ReadLine();
            reader.Close();
            return text;
        }
        static int Get_Result(string text)
        {
            string[] num = new string[2];
            text = text.Replace(" ", string.Empty);
            text = text.Remove(text.Length - 1);
            char[] operators = new char[3] { '+', '-', '*' };
            foreach (char i in operators)
            {
                if (text.IndexOf(i) != -1)
                {
                    num = text.Split(i);
                    switch (i)
                    {
                        case '+':
                            return Int16.Parse(num[0]) + Int16.Parse(num[1]);
                        case '-':
                            return Int16.Parse(num[0]) - Int16.Parse(num[1]);
                        case '*':
                            return Int16.Parse(num[0]) * Int16.Parse(num[1]);
                    }
                }
            }
            return 0;
        }
        static void Write_File(string text)
        {
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 1\Задание 1\Задание 1\output.txt";
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(text);
            writer.Close();
            Console.WriteLine("File succesfully writed!");
        }
    }
}
