using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add(5);
            list.Add(23);
            list.Add(1);
            list.Add(25);
            list.Add("Laba");
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(list[1]);

            ObservableCollection<Test> Observ = new ObservableCollection<Test>
            {
                new Test {NameF = "Первая"},
                new Test {NameF = "Вторая"},
                new Test {NameF = "Третья"}
            };



            List<float> numbers = new List<float>() { 1.6f, 56.9f, 100.3f };
            numbers.Add(2.3f);
            numbers.Insert(1, 5.1f);
            numbers.RemoveAt(3);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            double x;
            Console.WriteLine("Ввести число float ");

            string s = Console.ReadLine();
            bool b;
            x = double.Parse(s);

            Stack<double> stack = new Stack<double>();
            stack.Push(3.1);
            stack.Push(5.5);
            stack.Push(6.5);
            stack.Push(7.5);
            stack.Push(5.2);
            b = stack.Contains(x);
            Console.WriteLine(b);
            for(int i = 0; i<stack.Count; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            
        }
        public void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Test newUser = e.NewItems[0] as Test;
                    Console.WriteLine("Добавлен новый объект: {0}", newUser.NameF);
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Test oldUser = e.OldItems[0] as Test;
                    Console.WriteLine("Удален объект: {0}", oldUser.NameF);
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Test replacedUser = e.OldItems[0] as Test;
                    Test replacingUser = e.NewItems[0] as Test;
                    Console.WriteLine("Объект {0} заменен объектом {1}",
                                        replacedUser.NameF, replacingUser.NameF);
                    break;
            }
        }
        class Test
        {
            string _nameF;
            public string NameF
            {
                get
                {
                    return _nameF;
                }
                set
                {
                    _nameF = value;
                }
            }
        }
    }
}
