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
            double[,] arr = Get_Coordinates();
            if (Check_Triangle(arr))
            {
                Get_Info(Get_Sides(arr));
            }
            else
            {
                Console.WriteLine("Can't create triangle with this coordinates!");
            }
        }
        static double[,] Get_Coordinates()
        {
            double[,] arr = new double[3, 2];
            for(byte i = 1; i <= 3; i++)
            {
                Console.Write("X coordinate number " + i + ": ");
                arr[i - 1,0] = System.Convert.ToDouble(Console.ReadLine());
                Console.Write("Y coordinate number " + i + ": ");
                arr[i - 1, 1] = System.Convert.ToDouble(Console.ReadLine());
            }
            return arr;
        }
        static bool Check_Triangle(double[,] arr)
        {
            if (Math.Abs((arr[0, 0] - arr[2, 0]) * (arr[1, 1] - arr[2, 1]) - (arr[1, 0] - arr[2, 0]) * (arr[0, 1] - arr[2, 1])) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static double[] Get_Sides(double[,] arr)
        {
            double[] sides = new double[3];
            for (byte i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    sides[i] = Math.Sqrt(Math.Pow(arr[0, 0] - arr[2, 0], 2) + Math.Pow(arr[0, 1] - arr[2, 1], 2));
                    break;
                }
                sides[i] = Math.Sqrt(Math.Pow(arr[i + 1, 0] - arr[i, 0], 2) + Math.Pow(arr[i + 1, 1] - arr[i, 1], 2));
            }
            return sides;
        }
        static void Get_Info(double[] sides)
        {
            if (Math.Abs(sides[0]-sides[1])<0.00001 && Math.Abs(sides[0] - sides[2])<0.00001)
            {
                Console.WriteLine("This is equilateral triangle (all sides equal)");
                Console.WriteLine("Height of this triangle: " + Find_Height(sides[0]));
                Console.WriteLine("This is acute-angled triangle (all angles <90°)");
            }
            else if(sides[0]==sides[1] || sides[0]==sides[2] || sides[1] == sides[2])
            {
                Console.WriteLine("This is isosceles triangle (2 sides equal)");
                Console.Write("Median to base side: ");
                if (sides[0] == sides[1])
                {
                    Console.WriteLine(Find_Median(sides[2],sides[0]));
                }
                else if (sides[0] == sides[2])
                {
                    Console.WriteLine(Find_Median(sides[1], sides[0]));
                }
                else
                {
                    Console.WriteLine(Find_Median(sides[0], sides[1]));
                }
                Get_Angles(sides);
            }
            else
            {
                Console.WriteLine("This is versatile triangle (all sides are different)");
                Get_Angles(sides);
            }
        }
        static void Get_Angles(double[] sides)
        {
            double[] angles = new double[3];
            double a = sides[0], b = sides[1], c = sides[2];
            angles[0] = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
            angles[1] = Math.Acos((a * a + c * c - b * b) / (2 * a * c))*180/Math.PI;
            angles[2] = 180 - angles[0] - angles[1];
            if(Math.Abs(angles[0]-90)<0.00001 || Math.Abs(angles[1] - 90) < 0.00001 || Math.Abs(angles[2] - 90) < 0.00001)
            {
                Console.WriteLine("This is right triangle (one side = 90°)");
            }
            else if(angles[0]>90 || angles[1] > 90 || angles[2] > 90)
            {
                Console.WriteLine("This is obtuse triangle (one side > 90°)");
            }
            else
            {
                Console.WriteLine("This is acute-angled triangle (all angles <90°)");
            }
        }
        static double Find_Height(double side)
        {
            return (side * Math.Sqrt(3)) / 2;
        }
        static double Find_Median(double side_base, double side)
        {
            return 0.5 * Math.Sqrt(4 * side * side - side_base * side_base);
        }
    }
}
