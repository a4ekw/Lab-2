using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IType<T>
    {
        void Add(T i);
        void Rem(T i);
        void Out();
    }
    interface IMakingSomething
    {
        void GetOut();
    }
}
