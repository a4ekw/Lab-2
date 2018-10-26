using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        partial class Rings
        {
            private int X;
            private int Y;
            private int Rad;
            private static int num = 0;
            public readonly int ID;

            public Rings(int X, int Y, int Rad)
            {
                if (X > 0 && Y > 0 && Rad > 0)
                {

                    this.X = X;
                    this.Y = Y;
                    this.Rad = Rad;
                }
                else Console.WriteLine("Неверный ввод данных.");
                num++;
                ID = GetHashCode();
            }

            static Rings()
            {
                Console.WriteLine("Объект создан.");
            }

            private Rings() { }
        }
        partial class Rings
        {
            public override int GetHashCode()
            {
                return Convert.ToInt32(X * Y * Rad);
            }

            public override string ToString()
            {
                return $"Центр на оси х= {X} и оси у= {Y} с R= {Rad}";
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

        }
        partial class Rings
        {
            public double S()
            {
                return (3.14 * Rad * Rad);
            }
            public double P()
            {
                return (3.14 * 2 * Rad);
            }
        }
            partial class Rings
        {
            static void Main(string[] args)
            {
                Console.WriteLine("1. Input X, Y, Radius:");
                Rings First = new Rings(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                Console.WriteLine(First);
                Console.WriteLine($"Площадь окружности: { First.S()}");
                Console.WriteLine($"Длина окружности: { First.P()}");
                Console.WriteLine("2. Input X, Y, Radius:");
                Rings Second = new Rings(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                Console.WriteLine(Second);
                Console.WriteLine($"Площадь окружности: { Second.S()}");
                Console.WriteLine($"Длина окружности: { Second.P()}");
                Console.ReadLine();
            }
        }
    }
}
