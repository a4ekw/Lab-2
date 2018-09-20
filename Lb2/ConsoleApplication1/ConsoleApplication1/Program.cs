using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {


        public static String Ex(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "null или пустая";
            else
                return String.Format("(\"{0}\") не null или пустая", s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1");
            Part1();
            Console.WriteLine("Number 2");
            Part2();
            Console.WriteLine("Number 3");
            Part3();
            Console.WriteLine("Number 4");
            Part4();
            Console.WriteLine("Number 5");
            Console.WriteLine("Введите массив");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());//parse - преобразование ввеленной строки в int
            }
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            var tup = Part5(num, s);
            Console.WriteLine("Минимальный элемент " + tup.Item1 + " Максимальный " + tup.Item2 + " Их сумма " + tup.Item3 + " Первая Буква " + tup.Item4);

        }

        static void Part1()
        {
            Console.WriteLine("Определение переменных всех примитивных типов");
            bool q = true; //1 байт
            byte c = 255; // 0 - 255 8-битный
            char ch = 'Л';
            decimal dc = 12321412312323423423;
            double db = 45.6666;
            float fl = 123;
            int b = 99999999; //99 999 999 32-битный
            long e = 23372036854775808; //223 372 036 854 775 807 64-бит
            short d = 30000; //-32768 до 32767 16-битный
            sbyte a = -50; //от -128 до 127 1 байт
            ushort f = 65535; // 0 - 65535
            uint g = 4294967295;  // 0 -
            ulong h = 18446744073709551615; // 0 -


            //неявное приведение
            byte bt = 5;
            short s = bt;
            int i = b;
            long l = b;

            //явное приведение
      
            byte byt = (byte)d;// из short в byte
            double nd = (double)b;//из int  в  double
        
            //упаковка-распаковка
            int z = 66;
            Object obj = z; //ссылка на упакованный объект
            byte L = (byte)(int)obj; //распаковка и приведение типа

            //работа с неявно типизированной переменной
            var MyVar1 = new[] { '1', '2', '3' };
            Console.WriteLine(MyVar1.GetType());

            var MyVar2 = new[] { 123, 1.654, 1 };
            Console.WriteLine(MyVar2.GetType());

            var MyVar3 = new List<int>
                (new int[] { 1, 2, 3, 4, 5, 6, 7,});
            Console.WriteLine(MyVar3.GetType());

            //NULLABLE
            double? NA1 = null;
           double? NA2 = null;
            Console.Write("NullAble 1 == NullAble 2? "); System.Console.WriteLine(NA1 == NA2);

            int? zz = null;
            if (zz.HasValue)
            {
                int zz1 = (int)zz; //явное приведение
                int? zz2 = zz1; //неявное приведение
                long? zz3 = zz2; //неявное расширяющее приведение
            }
            int? yy = null;
            int V = yy ?? 1;//возвращает 1
            Console.WriteLine(V);
        }

        static void Part2()
        {
            Console.WriteLine("Строки ");
            string str1 = "Лаб. ";
            string str2 = "работа";
            string str3 = "! ";
            string str4 = "Лаб. ";
            string strO = "";
            Console.WriteLine("Сравнение: " + (str1 == str2));
            Console.WriteLine("Сравнение: " + (str1 == str4));
            strO = str1 + str2 + str3 + str4;
            Console.WriteLine("Слияние всех строк в одну: " + strO);
            string Cp = str4;
            Console.WriteLine("Копирование: " + Cp);
            string stri = str4.Substring(0, 2);
            Console.WriteLine("Выделение подстроки: " + stri);

            string Dev = "Hello! It's my Lab number 2.";
            char[] del = ".,:;!?\n\xD\xA\' ' ".ToCharArray();
            string[] words = Dev.Split(del);
            foreach (string www in words)
                Console.WriteLine(www);
            Console.WriteLine();

            Console.WriteLine("Вставка подстроки на 6 позицию " + str4.Insert(5, stri));

            Console.WriteLine();
            string fullstr = "Hello! It's my Lab number 2.";
            Console.Write("Введите подстроку:");
            string substr = Console.ReadLine();
            int nnnn = fullstr.IndexOf(substr);
            fullstr = fullstr.Remove(nnnn, substr.Length);
            Console.WriteLine(" " + fullstr);

            Console.WriteLine();
            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Ex(s1));
            Console.WriteLine("String s2 {0}.", Ex(s2));
            Console.WriteLine("String s3 {0}.", Ex(s3));



            StringBuilder sb = new StringBuilder("Изучение C#!");

            sb.Remove(0, 3);
            sb.Append("!");//добавление в конец строки
            sb.Insert(0, "Слово ");
            Console.WriteLine(sb);
        }

        static void Part3()//массивы
        {//ступенчатый массив
            int[][] array = { new int[3] { 1, 2, 3 }, new int[3] { 28, 16, 34 }, new int[3] { 21, 22, 33 } };
            foreach (int[] x in array)
            {
                foreach (int b in x)
                    Console.WriteLine("\t" + b);
                Console.WriteLine();
            }
            Console.WriteLine("Строковый массив:");
            string[] str = new string[] { "It's", "My", "Lab" };
            foreach (string b in str)
                Console.WriteLine("\t" + b);
            Console.WriteLine("длина: " + str.Length);
            Console.WriteLine("Замена:");
            Console.WriteLine("Введите значение");
            string value = Console.ReadLine();
            Console.WriteLine("Введите позицию");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (num == i)
                {
                    str[num] = value;

                }
                Console.WriteLine(str[i]);
            }


            int[][] abc = new int[3][];
            abc[0] = new int[1];//1 элемент в 1 строке
            abc[1] = new int[2];
            abc[2] = new int[3];//3 элемента в 3 строке
            Console.WriteLine("\nВведите элемент заполнения массива");
            double[][] c = { new double[1], new double[2], new double[3] };
            int n = 2;
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[][] с = new int[5][];
            for (int i = 0; i < abc.Length; i++)
            {
                с[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    с[i][j] = k;
                    Console.Write("{0} ", с[i][j]);
                }
                Console.WriteLine();
                n++;
            }

            var arra = new object[0];
            var sstr = "";

        }

        static void Part4()
        {
            var myTup = Tuple.Create<int, string, char, string, ushort>(123, "asdasda", 's', "gdgf", 123);
            //a
            Console.WriteLine(myTup.Item1 + " " + myTup.Item2 + " " + myTup.Item3 + " " + myTup.Item4 + " " + myTup.Item5);//Item по умолчанию
            //b
            Console.WriteLine();
            Console.WriteLine(myTup.Item1 + " " + myTup.Item3 + " " + myTup.Item4);
            //c распаковка кортежа в переменные
            int acl = myTup.Item1;
            string av = myTup.Item2;
            char cl = myTup.Item3;
            string vbh = myTup.Item4;
            ushort nnn = myTup.Item5;
            var myTup2 = Tuple.Create<int, string, char, string, ushort>(123, "Lab", 's', "FIT", 123);
            Console.WriteLine();
            Console.WriteLine(myTup.Equals(myTup2));// сравнение двух кортежей
        }

        static Tuple<int, int, int, string> Part5(int[] num, string s)
        {
            int min = num[0];
            int max = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            int sum = max + min;
            string firstLetter = s.Substring(0, 1);

            return Tuple.Create<int, int, int, string>(min, max, sum, firstLetter);
        }
    }

}
