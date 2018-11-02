using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
            Console.Write("Отвечаем на вопросы.\n");
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
            Console.WriteLine("Делаем тест.");
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
            Console.Write("Сдвем экзамен.\n");
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
            Console.Write("Сдаем выпускной экзамен.\n");
        }
        public sealed override void GetOut()
        {
            Console.Write("Get Out.\n");
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
