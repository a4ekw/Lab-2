using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Question : IMakingSomething
    {
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
}
