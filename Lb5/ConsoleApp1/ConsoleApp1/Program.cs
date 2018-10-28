using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Question Vopros1 = new Question();
            Vopros1.Quest = "Какой-то easy вопрос.\n";
            Vopros1.ToString();
            Vopros1.Do();
            Vopros1.GetOut();

            Console.WriteLine();
            
            Test Test1 = new Test();
            Test1.T();
            Test1.Testing = "Какой-то тест.\n";
            Test1.ToString();
            Test1.Do();
            Test1.GetOut();

            Console.WriteLine();

            Exam Exam1 = new Exam();
            Exam1.E();
            Exam1.Examin = "Какой-то экзамен.\n";
            Exam1.ToString();
            Exam1.Do();
            Exam1.GetOut();

            Console.WriteLine();

            FinalExam FinEx1 = new FinalExam();
            FinEx1.FE();
            FinEx1.Final = "Какой-то выпускной экзамен\n";
            FinEx1.ToString();
            FinEx1.Do();
            FinEx1.GetOut();

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}