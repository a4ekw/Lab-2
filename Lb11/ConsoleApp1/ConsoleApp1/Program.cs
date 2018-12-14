using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            double[] D = new double[3];
            for (int i = 0; i < 3; i++)
            {
                S[i] = Pi * Center[i][2] * Center[i][2];
                D[i] = 2 * Pi * Center[i][2];
            }
            var Ss = from i in S where i > 0 select i;
            var Sl = from i in S orderby i select i;
            foreach (double i in S)
                Console.WriteLine("Площадь окружности:{0}", i);
            foreach (double i in D)
                Console.WriteLine("Длинна окружности:{0}", i);
            Console.WriteLine("\n\nУпорядоченные площади:\n");
            foreach (double i in Sl)
                Console.WriteLine(i);
            Console.WriteLine();
            MinMax(D, S);
            Output(Center);
        }
        static void MinMax(double[] P, double[] S)
        {
            var Mins = from i in S where i == S.Min() select i;
            var Maxs = from i in S where i == S.Max() select i;
            var Minp = from i in P where i == P.Min() select i;
            var Maxp = from i in P where i == P.Max() select i;
            foreach (double i in Maxs)
                Console.WriteLine("Самая большая площадь: {0}", i);
            foreach (double i in Mins)
                Console.WriteLine("Самая маленькая площадь: {0}", i);
            Console.WriteLine();
            foreach (double i in Maxp)
                Console.WriteLine("Самая большая длина: {0} ", i);
            foreach (double i in Minp)
                Console.WriteLine("Самая маленькая длина: {0} ", i);
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
                Console.WriteLine("Центры всех окружностей на одной прямой X.");
            else
            {
                if (Center[0][0] == Center[1][0])
                {
                    Console.WriteLine("Центры 1 и 2 окружностей на одной прямой X.");
                }
                else X1 = false;
                if (Center[2][0] == Center[1][0])
                {
                    Console.WriteLine("Центры 2 и 3 окружностей на одной прямой X.");
                }
                else X2 = false;
            }
            if (X1 == false && X2 == false) Console.WriteLine("Окружностей с центрами на одной прямой Y нет.");

            if (Center[0][1] == Center[1][1] && Center[1][1] == Center[2][1])
                Console.WriteLine("Центры всех окружностей на одной прямой Y.");
            else
            {
                if (Center[0][1] == Center[1][1])
                {
                    Console.WriteLine("Центры 1 и 2 окружностей на одной прямой Y.");
                }
                else Y1 = false;
                if (Center[2][1] == Center[1][1])
                {
                    Console.WriteLine("Центры 2 и 3 окружностей на одной прямой Y.");
                }
                else Y2 = false;
            }
            if (Y1 == false && Y2 == false) Console.WriteLine("Окружностей с центрами на одной прямой Y нет.");
            Console.Read();
        }

        class S<T> : List<T> where T: Circle
        { 

        }

        static public void Main(string[] args)
        {
            string[] Mon = new string[] { "Jan", "Feb", "March", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            Console.WriteLine("Месяца с длиной строки равной 3:");
            var M = from name in Mon
                    where name.Count() == 3
                    select name;
            foreach (string str in M)
                Console.WriteLine(str);
            Console.WriteLine("\nЗимние месяцы:");
            var W = from name in Mon
                    where name == Mon[11] || name == Mon[0] || name == Mon[1]
                    select name;
            foreach (string str in W)
                Console.WriteLine(str);
            Console.WriteLine("\nЛетние месяцы:");
            var S = from name in Mon
                    where name == Mon[5] || name == Mon[6] || name == Mon[7]
                    select name;
            foreach (string str in S)
                Console.WriteLine(str);

            #region Lb3
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
            #endregion
        }
    }
}