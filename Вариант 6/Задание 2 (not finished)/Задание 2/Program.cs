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
            bool[,] arr = Read_Matrix(12, 10);
            Console.WriteLine(Solve(arr, 12, 10));
        }
        static bool[,] Read_Matrix(short size_m, short size_n)
        {
            string path = @"C:\Users\DENYS\Desktop\Олимпиада\Вариант 6\Задание 2\Задание 2\File.txt";
            bool[,] arr = new bool[size_m, size_n];
            string tmp;
            short j = 0;
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream || size_m > 0)
            {
                tmp = reader.ReadLine();
                for (short i = 0; i < size_n; i++)
                {
                    arr[j, i] = (tmp[i * 2] == '1');
                }
                j++;
                size_m--;
            }
            return arr;
        }
        static short Solve(bool[,] arr, short m, short n)
        {
            short result = 0;
            List<short> d = new List<short>(n);
            short[] d1 = new short[n];
            short[] d2 = new short[n];
            Stack<short> st = new Stack<short> { };
            for(short i = 0; i < n; i++)
            {
                d.Add(-1);
            }
            for(short i = 0; i < m; i++)
            {
                for(short j = 0; j < n; j++)
                {
                    if (arr[i, j])
                    {
                        d[j] = i;
                    }
                }
                while (st.Count != 0)
                {
                    st.Pop();
                }
                for(short j = 0; j < n; j++)
                {
                    while(st.Count!=0 && d[st.Peek()] <= d[j])
                    {
                        st.Pop();
                    }
                    d1[j] = (st.Count == 0 ? (short)-1 : st.Peek());
                    st.Push(j);
                }
                while (st.Count != 0)
                {
                    st.Pop();
                }
                for(short j=(short)(n-1);j>=0; j--)
                {
                    while (st.Count != 0 && d[st.Peek()] <= d[j])
                    {
                        st.Pop();
                    }
                    d2[j] = st.Count == 0 ? n : st.Peek();
                    st.Push(j);
                }
                for(short j = 0; j < n; j++)
                {
                    result = (short)Math.Max(result, (i - d[j]) * (d2[j] - d1[j] - 1));
                }
            }
            return result;
        }
    }
}
