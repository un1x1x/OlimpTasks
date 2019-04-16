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
        static void Main(string[] args) //true = not swap: false = swap;
        {
            List<char> alphabet = Get_Alphabet();
            Console.Write("Alphabet: ");
            foreach(char i in alphabet)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            Console.Write("Not sorted string: ");
            string[] arr = Read_File();
            foreach (string str in arr)
            {
                Console.Write(str+ "  ");
            }
            Console.WriteLine();
            QuickSort(arr, alphabet,0,(short)(arr.Length-1));
            Console.Write("Sorted string: ");
            foreach(string str in arr)
            {
                Console.Write(str + "  ");
            }
            Console.WriteLine();
        }
        static List<char> Get_Alphabet()
        {
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 5\Задание 2\Задание 2\input.txt";
            var text = File.ReadAllText(path);
            List<char> arr = new List<char> { };
            for(byte i=0;i<text.Length;i+=2)
            {
                arr.Add(text[i]);
            }
            return arr;
        }
        static bool Compare(string first, string second, List<char> arr)
        {
            for(byte i=0;i<(first.Length>second.Length ? second.Length : first.Length);i++)
            {
                for(byte j = 0; j < arr.Count; j++)
                {
                    if(first[i]==arr[j] && second[i] != arr[j])
                    {
                        return false;
                    }
                    else if(first[i] != arr[j] && second[i] == arr[j])
                    {
                        return true;
                    }
                    else if(first[i]==arr[j] && second[i] == arr[j])
                    {
                        break;
                    }
                }
            }
            return (first.Length>second.Length ? true : false);
        }
        static string[] Read_File()
        {
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 5\Задание 2\Задание 2\input_text.txt";
            var text = File.ReadAllText(path);
            return text.Split(',');
        }
        static short Partition(string[] arr, List<char> alphabet, short start, short end)
        {
            string tmp;
            short mark = start;
            for(short i = start; i <= end; i++)
            {
                if(Compare(arr[end], arr[i], alphabet))
                {
                    tmp = arr[mark];
                    arr[mark] = arr[i];
                    arr[i] = tmp;
                    mark++;
                }
            }
            tmp = arr[mark];
            arr[mark] = arr[end];
            arr[end] = tmp;
            return mark;
        }
        static void QuickSort(string[] arr, List<char> alphabet, short start, short end)
        {
            if (start >= end)
            {
                return;
            }
            short pivot = Partition(arr, alphabet, start, end);
            QuickSort(arr,alphabet, start, (short)(pivot - 1));
            QuickSort(arr, alphabet, (short)(pivot + 1), end);
        }
    }
}
