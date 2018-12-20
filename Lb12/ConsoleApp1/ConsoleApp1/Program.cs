using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace lab12
{
    internal class Program
    {
        class ClassQ
        {
            public int i = 666;
            public int j = -13;

            public void Test() { }
        }
        class _Reflector
        {
            public static void GetContents(Object o)
            {
                Type t = o.GetType();
                FieldInfo[] fields = t.GetFields();  
                StreamWriter sw = new StreamWriter(t.Name + "qwer.txt", true);
                foreach (var f in fields)
                {
                    sw.WriteLine($"{f.Name} = {f.GetValue(o)}");
                }
                sw.Close();
            }

            public static void GetPublicMethods(Object o)
            {
                Type t = o.GetType();
                foreach(var el in t.GetMethods())
                {
                    Console.WriteLine(el);
                }
            }
        }

        public static void Main(string[] args)
        {
            _Reflector.GetContents(3);
            _Reflector.GetContents(new ClassQ());
            _Reflector.GetPublicMethods(new ClassQ());
        }
    }
}