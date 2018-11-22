using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int DELEG();
    public delegate void DELEG2(int i);
    public delegate void RUN();
    class Program
    {
        public class Boss
        {
            public event RUN Run;
            public event RUN Broken;
            int lvl = 1;
            public void Upgrade()
            {
                lvl++;
            }
            public void TurnOn(int V)
            {
                if (V == 9) Run();
                if (V < 9) Console.WriteLine("Voltage is Low!");
                if (V >= 10) Broken();
            }
            public void EventRun()
            {
                Console.WriteLine("Boss Is Running!\n\n");
            }
            public void EventBreak()
            {
                Console.WriteLine("Boss Is Broken!\nVery High Voltage!\n\n");
            }
        }
        public class Tech
        {
            int HP;
            public Tech(int H)
            {
                this.HP = H;
                Console.WriteLine($"Tech HP:{HP}");
            }
            public void GetDmg(int i)
            {
                HP -= i;
                ShowHP();
                Console.WriteLine();
            }
            public void ShowHP()
            {
                Console.WriteLine($"Tech HP:{HP}");
            }
            public int GetHP()
            {
                return HP;
            }
        }
        public class Human
        {
            int HP;
            public Human(int H)
            {
                this.HP = H;
                Console.WriteLine($"Human HP:{HP}");
            }
            public void GetDmg(int i)
            {
                HP -= i;
                ShowHP();
                Console.WriteLine();
            }
            public void ShowHP()
            {
                Console.WriteLine($"Human HP:{HP}");
            }
            public int GetHP()
            {
                return HP;
            }
        }
        public class Damage
        {
            public event DELEG2 Check;
            int Dmg;
            Random Rand = new Random();
            public int Human()
            {
                Dmg = Rand.Next(1, 3);
                Check(Dmg);
                return Dmg;
            }
            public int Tech()
            {
                Dmg = Rand.Next(0, 2);
                Check(Dmg);
                return Dmg;
            }
            public void Show(int i)
            {
                Console.WriteLine($"Получает урон:{i}");
            }
        }
        public static void Main()
        {
            Random Rand = new Random();
            Boss BB = new Boss();
            int H, V = 0;
            int Try = 1;
            BB.Run += BB.EventRun;
            BB.Broken += BB.EventBreak;
            while (V < 9)
            {
                Console.WriteLine("Включить питание?");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($" Попытка №{Try}");
                BB.TurnOn(V = Rand.Next(6, 13));
                Try++;
            }
            Damage D = new Damage();

            D.Check += D.Show;
            DELEG DamageT = D.Tech;

            Tech T = new Tech(H = Rand.Next(3, 6));
            Console.WriteLine("Нанести случайный урон Tech->");
            Console.ReadKey();
            int t = DamageT();
            T.GetDmg(t);

            Human Hum = new Human(H = Rand.Next(3, 6));
            Console.WriteLine("Нанести случайный урон Tech->");
            Console.ReadKey();
            DELEG DamageH = D.Human;
            int h = DamageH();
            Hum.GetDmg(h);
        }    
    }
}
