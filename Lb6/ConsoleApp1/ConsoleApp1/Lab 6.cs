using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class CControler : Session
    {
            public string str { get; set; } 
    }
    public abstract class Session
    {
        List<List<Test>> zlist = new List<List<Test>>();
        List<List<Exam>> elist = new List<List<Exam>>();
        
        public void CPush(List<Test> item)
        {
            zlist.Add(item);
        }
        public void CRem(List<Test> item)
        {
            zlist.Remove(item);
        }
        public int Serch(int size)
        {
            int i = 0;
            foreach (List<Test> zach in zlist)
            {
                foreach (Test test in zach)
                {
                    if (test.Size == size)
                    {
                        i++;
                        return size;
                    }
                }
            }
            if (i == 0) return 0; 
            return size;
        }

        public void CPush(List<Exam> item)
        {
            elist.Add(item);
        }
        public void CRem(List<Exam> item)
        {
            elist.Remove(item);
        }
    }

    #region Zachet

    public class Zach
    {
        List<Test> zachlist = new List<Test>();
        public void ZPush(Test item)
        {
            zachlist.Add(item);
        }
        public void ZRem(Test item)
        {
            zachlist.Remove(item);
        }
        public List<Test> Get()
        {
            return zachlist;
        }
        public int GetLength()
        {
            return zachlist.Count;
        }

    }
    public partial class Test
    {
        private int _size;
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public void TOut()
        {
            Console.WriteLine(Size); 
        }

    }
    #endregion

    #region Exam
    public partial class Exam <Subject>
    {
        static int index = 0;
        public static Subject[] examArray = new Subject[index + 1];
        public void EPush(Subject item)
        {
            examArray[index++] = item;
        }
        public Subject ERem()
        {
            return examArray[--index];
        }
        public Subject[] EGet()
        {
            return examArray;
        }
    }
    public sealed class Subject
    {
        private int _subj;
        public int Subj
        {
            get { return _subj; }
            set { _subj = value; }
        }
    }
    #endregion
}
