using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lab8<T> : IType<T>
    {
        List<T> Types = new List<T>();
        public void Add(T i)
        {
            Types.Add(i);
        }
        public void Rem(T i)
        {
            Types.Remove(i);
        }
        public void Out()
        {
            foreach (T item in Types)
            {
                Console.WriteLine(item);
            }
        }

    }
    class Limited<U> where U : Test { }

    internal class FindTestException : ApplicationException
    {
        public override string Message => "\n--------------\nТест не найден!\n--------------\n";

    }
    internal class ErrorData : ApplicationException
    {
        public override string Message => "\n--------------\nЗначение не может быть меньше или равно 0!\n--------------\n";
    }


    abstract class Example : IMakingSomething 
    {
        public void GetOut()
        {
            Console.Write("Abstract: Get Out.\n");
        }
    }
    public partial class Question : IMakingSomething
    {
        public string _quest;
        public string Quest
        {
            get { return _quest; }
            set { _quest = value; }
        }
        public virtual void GetOut()
        {
            Console.Write("Get Out.\n");
        }
        public virtual void Do()
        {
            Console.Write("Making Question.\n");
        }
        public override string ToString()
        {
            Console.WriteLine($"Вопрос: {Quest}");
            return "";
        }
    }
    public partial class Test : Question
    {
        public string _testing;
        public string Testing
        {
            get { return _testing; }
            set { _testing = value; }
        }
        public sealed override void Do()
        {
            Console.WriteLine("Making Test.");
        }
        public void T()
        {
            Console.Write("Unic Test.\n");
        }
        public sealed override string ToString()
        {
            Console.WriteLine($"Тест: {Testing}");
            return "";
        }
    }
    public sealed partial class Exam : Question
    {
        public string _examin;
        public string Examin
        {
            get { return _examin; }
            set { _examin = value; }
        }
        public sealed override void Do()
        {
            Console.Write("Examination.\n");
        }
        public void E()
        {
            Console.Write("Unic Exam.\n");
        }
        public sealed override string ToString()
        {
            Console.WriteLine($"Экзамен: {Examin}");
            return "";
        }
    }
    public sealed class FinalExam : Question
    {
        public string _final;
        public string Final
        {
            get { return _final; }
            set { _final = value; }
        }
        public sealed override void Do()
        {
            Console.Write("It's Final Examination.\n");
        }
        public sealed override void GetOut()
        {
            Console.Write("Get Out After Final Examination.\n");
        }
        public void FE()
        {
            Console.Write("Unic Final Exam.\n");
        }
        public sealed override string ToString()
        {
            Console.WriteLine($"Выпускной экзамен: {Final}");
            return "";
        }
    }
    public abstract class Printer
    {
        virtual public void IAmPrinting(Question obj)
        {
            if (obj is Test)
            {
                Console.WriteLine(obj.ToString()); ;
            }

            if (obj is Exam)
            {
                Console.WriteLine(obj.ToString());
            }

            if (obj is FinalExam)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
