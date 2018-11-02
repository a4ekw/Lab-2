using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum Numbers
        {
            Lab = 6,
            Group,
            Course = 2
        }

        struct Number
        {
            public int N;
            public int G;
            public int C;
        }

        static void Main(string[] args)
        {
            Number Num;
            Num.N = (int)Numbers.Lab;
            Num.G = (int)Numbers.Group;
            Num.C = (int)Numbers.Course;

            Console.WriteLine($"Лаб. раб. №{Num.N}.");
            Console.WriteLine($"Вариант {Num.G}.");
            Console.WriteLine($"{Num.G} группа.");
            Console.WriteLine($"{Num.C} курс.\n");

            Test Error = new Test();
            Test Test1 = new Test();
            Test1.Size = 10;
            Test Test2 = new Test();
            Test2.Size = 15;
            Zach Zachet = new Zach();
            Zachet.ZPush(Test1);
            Zachet.ZPush(Test2);
            Console.WriteLine($"Количество испытаний: {Zachet.GetLength()}");

            CControler Controler = new CControler();
            List<Test> tests = new List<Test>();
            tests = Zachet.Get();
            Controler.CPush(tests);
            Console.WriteLine("Поиск по количеству вопросов в тесте: 10.");
            int Find = Controler.Serch(10);
            switch (Find)
            {
                case 10:
                    {
                        Console.WriteLine("Test 1.");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("Test 2.");
                        break;
                    }
            }

            Console.ReadKey();
            Console.Clear();

            #region Laba 5
            Console.WriteLine($"Лаб. раб. №5.");
            Question Vopros1 = new Question();
            Vopros1.Quest = "Какой-то easy вопрос.";
            Vopros1.ToString();
            Vopros1.Do();
            Vopros1.GetOut();

            Console.WriteLine();
            
            Test T1 = new Test();
            T1.T();
            T1.Testing = "Какой-то тест.";
            T1.ToString();
            T1.Do();
            T1.GetOut();

            Console.WriteLine();

            Exam Exam1 = new Exam();
            Exam1.E();
            Exam1.Examin = "Какой-то экзамен.";
            Exam1.ToString();
            Exam1.Do();
            Exam1.GetOut();

            Console.WriteLine();

            FinalExam FinEx1 = new FinalExam();
            FinEx1.FE();
            FinEx1.Final = "Какой-то выпускной экзамен.";
            FinEx1.ToString();
            FinEx1.Do();
            FinEx1.GetOut();

            Console.WriteLine();

            Console.ReadKey();
            #endregion
        }
    }
}