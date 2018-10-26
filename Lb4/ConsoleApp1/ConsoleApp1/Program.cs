using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_4
{
    class MySet : HashSet<int>
    {
        static public string Str;
        static Random Rnd = new Random();
        public static MySet Rand(MySet C, string Str)
        {
            Console.Write($"Input size of {Str}");
            int x = int.Parse(Console.ReadLine());
            int Val = 0, Val2 = 0, S = 5;
            for (int i = 0; i < x; i++)
            {
            Point: Val = Rnd.Next(0, S);
                if (Val > Val2)
                {
                    C.Add(Val);
                    Val2 = Val;
                    S += 5;
                }
                else goto Point;
            }
            foreach (int V in C)
            {
                Console.Write($" {V} |");
            }
            Console.WriteLine("\n");
            return C;
        }

        public static MySet operator ++(MySet C)
        {
            C.Add(Rnd.Next(100, 500));
            return C;
        }
        public static MySet operator +(MySet C, MySet D)
        {
            foreach (int Val in D)
                C.Add(Val);
            return C;
        }

        public static bool operator <=(MySet C, MySet D)
        {
            if (C.Count == D.Count) { return false; }
            else
            {
                if (C.Count < D.Count) { return true; }
                else { return true; }
            }
        }
        public static bool operator >=(MySet C, MySet D)
        {
            return C.Count > D.Count;
        }
        public static int operator %(MySet C, int Ind)
        {
            return C.ElementAt(Ind);
        }
        public static int sizeOfSet(MySet C)
        {
            return C.Count;
        }
        public class Owner
        {
            int id;
            string name;
            public Owner(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public void Out()
            {
                Console.WriteLine($"\n Organization: {this.name}, id = {this.id}\n");
                Console.ReadLine();
            }
        }

        public class Date
        {
            string Today;
            public Date(string Today)
            {
                this.Today = Today;
                this.Today = Today;
            }
            public void Out()
            {
                Console.WriteLine($"Fixed Date: {this.Today} ");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            MySet C = new MySet();
            MySet D = new MySet();
            Rand(C, "Set 1:");
            Rand(D, "Set 2:");

            Owner CopyRight = new Owner(Rnd.Next(111, 999), "BSTU");
            CopyRight.Out();
            Console.WriteLine("Input Date (string): ");
            Date Dt = new Date(Console.ReadLine());
            Dt.Out();
            Console.WriteLine("\n Добавл случ эл-та к 1 мн-ву:");
            Stat.NewAl(C);
            foreach (int V in C)
            {
                Console.Write($" {V} |");
            }
            Console.ReadLine();
            Console.WriteLine("\n Объединение 1 и 2 мн.:");
            Stat.Ob(C, D);
            foreach (int V in C)
            {
                Console.Write($" {V} |");
            }
            Console.ReadLine();
            bool Sr;
            Console.WriteLine();
            Sr = C <= D;
            Console.WriteLine($"\n{Sr}");
            Console.Write("Введите индекс эл-та:");

            int index = int.Parse(Console.ReadLine());
            int Al = Stat.Index(C, index);
            Console.Write($"Элем. с индексом {index} : \n|> {Al} <|\n");

            Console.WriteLine($"Мощность множества: {sizeOfSet(C)}");

            Console.ReadLine();
            Console.Clear();

            Console.Write("Input sttring: ");
            Str = (Console.ReadLine());
            StringBuilder S = new StringBuilder(Str);
            Stat.Coding(S);
            Console.Write($"Шифрованная строка: {S}\n");
            Console.ReadLine();
        }
    }
    static class Stat
    {
        public static StringBuilder Coding( StringBuilder Str)
        {
            Str.Replace("0", "Z");
            Str.Replace("1", "O");
            Str.Replace("2", "T");
            Str.Replace("3", "Tr");
            Str.Replace("4", "F");
            Str.Replace("5", "Fi");
            Str.Replace("6", "S");
            Str.Replace("7", "Se");
            Str.Replace("8", "E");
            Str.Replace("9", "N");
            return Str;
        }

        public static MySet NewAl(MySet C)
        {
            return(C++);
        }

        public static MySet Ob(MySet C, MySet D)
        {
            C = C + D;
            return(C);
        }
        public static int Index(MySet C,int x)
        {

            return C % x;
        }
    }
}