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
            Console.Write("Start Range: ");
            ushort num = System.Convert.ToUInt16(Console.ReadLine());
            Console.Write("End Range: ");
            ushort num1 = System.Convert.ToUInt16(Console.ReadLine());
            List<ushort> arr = new List<ushort> (num1);
            for(int i = 2; i <= num1; i++)
            {
                arr.Add((ushort)i);
            }
            SortedSet<ushort> not_simple = new SortedSet<ushort> { };
            foreach(ushort i in arr)
            {
                if (!not_simple.Contains(i))
                {
                    if ((int)i * i > (int)num1)
                    {
                        break;
                    }
                    for (int j = i * i; j <= num1; j += i)
                    {
                        not_simple.Add((ushort)j);
                    }
                    arr = arr.Except(not_simple).ToList();
                }
                else
                {
                    continue;
                }
            }
            for (; num < num1;num++)
            {
                if (arr.Exists(item => item==num)==true)
                {
                    for(ushort i = System.Convert.ToUInt16(arr.BinarySearch(num)); (arr[i]<=num1) || (i<arr.Count-1); i++)
                    {
                        Console.WriteLine(arr[i]);
                        if (arr.Count - 1 == i)
                        {
                            break;
                        }
                    }
                    break;
                }
            }
                
        }
    }
}
