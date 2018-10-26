using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Circle
    {
        static void T(ref int[][] Center)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Координата X центра {0} окружности(0<X<10):", i + 1);
                Center[i][0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Координата Y центра {0} окружности(0<Y<10):", i + 1);
                Center[i][1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Радиус окружности:");
                Center[i][2] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
        }

        static void Check(int[][] Center, ref bool Ch)
        {
            foreach (int[] x in Center)
            {
                foreach (int b in x)
                {
                    if (b <= 0 || b > 9)
                    {
                        Console.WriteLine("Неверный ввод данных!");
                        Console.ReadLine();
                        Ch = false;
                        break;
                    }
                }
            }
        }

        static void Calc(int[][] Center)
        {
            const double Pi = 3.14;
            double[] S = new double[3];
            double[] P = new double[3];
            for (int i = 0; i < 3; i++)
            {
                S[i] = Pi * Center[i][2] * Center[i][2];
                P[i] = 2 * Pi * Center[i][2];
                Console.WriteLine("Площадь {0} окружности:{1}", i + 1, S[i]);
                Console.WriteLine("Длинна {0} окружности:{1}", i + 1, P[i]);
                Console.WriteLine();
            }
            MinMax(ref P, ref S);
            Output(Center);
        }
        static void MinMax(ref double[] P, ref double[] S)
        {
            double Mins = S.Min();
            double Maxs = S.Max();
            double Minp = P.Min();
            double Maxp = P.Max();
            Console.WriteLine("Самая большая площадь: {0}", Maxs);
            Console.WriteLine("Самая маленькая площадь: {0}", Mins);
            Console.WriteLine();
            Console.WriteLine("Самая большая длина: {0} ", Maxp);
            Console.WriteLine("Самая маленькая длина: {0} ", Minp);
            Console.ReadLine();
            Console.Clear();
        }

        static void Output(int[][] Center)
        {
            bool X1 = true;
            bool X2 = true;
            bool Y1 = true;
            bool Y2 = true;
            if (Center[0][0] == Center[1][0] && Center[1][0] == Center[2][0])
                Console.WriteLine("Центры всех окружностей на одной примой X.");
            else
            {
                if (Center[0][0] == Center[1][0])
                {
                    Console.WriteLine("Центры 1 и 2 окружностей на одной примой X.");
                }
                else X1 = false;
                if (Center[2][0] == Center[1][0])
                {
                    Console.WriteLine("Центры 2 и 3 окружностей на одной примой X.");
                }
                else X2 = false;
            }
            if (X1 == false && X2 == false) Console.WriteLine("Окружностей с центрами на одной примой Y нет.");

            if (Center[0][1] == Center[1][1] && Center[1][1] == Center[2][1])
                Console.WriteLine("Центры всех окружностей на одной примой Y.");
            else
            {
                if (Center[0][1] == Center[1][1])
                {
                    Console.WriteLine("Центры 1 и 2 окружностей на одной примой Y.");
                }
                else Y1 = false;
                if (Center[2][1] == Center[1][1])
                {
                    Console.WriteLine("Центры 2 и 3 окружностей на одной примой Y.");
                }
                else Y2 = false;
            }
            if (Y1 == false && Y2 == false) Console.WriteLine("Окружностей с центрами на одной примой Y нет.");
            Console.Read();
        }
        static public void Main(string[] args)
        {
            int[][] Center = new int[3][];
            Center[0] = new int[3];
            Center[1] = new int[3];
            Center[2] = new int[3];
            bool Ch = true;
            Console.WriteLine("Введите значения для 3 окружностей:");
            T(ref Center);
            Check(Center, ref Ch);
            if (Ch == true)
            {
                Calc(Center);
            }
        }
    }
}

