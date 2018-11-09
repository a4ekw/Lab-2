using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FindTestException : ApplicationException
    {
        public override string Message => "\n--------------\nТест не найден!\n--------------\n";

    }
    internal class ErrorData : ApplicationException
    {
        public override string Message => "\n--------------\nЗначение не может быть меньше или равно 0!\n--------------\n";
    }
}
