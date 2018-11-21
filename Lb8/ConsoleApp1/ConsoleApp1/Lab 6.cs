//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{

//    class Session
//    {
//        public List<Zach> ZachList
//        { get; set; }
//        public List<Exam> ExamList
//        { get; set; }

//        public void AddItem(Zach item)
//        {
//            ZachList.Add(item);
//        }
//        public void RemoveItem(Zach item)
//        {
//            ZachList.Remove(item);
//        }
//        public void Show()
//        {
//            foreach (Zach item in ZachList)
//            {
//                Console.Write(item.TestList + " ");
//            }
//            Console.Write("\n");
//        }
//    }
//    #region Zachet
//    public class Zach
//    {
//        public List<Test> TestList
//        { get; set; }

//        public Zach(List<Test> Testlist)
//        {
//            this.TestList = TestList;
//        }
//        public void AddItem(Test item)
//        {
//            TestList.Add(item);
//        }
//        public void RemoveItem(Test item)
//        {
//            TestList.Remove(item);
//        }
//        public void Show()
//        {
//            foreach (Test item in TestList)
//            {
//                Console.Write(item.Size + " ");
//            }
//            Console.Write("\n");
//        }
//        public void FindTest(int Item)
//        {
//            foreach (Test i in TestList)
//            {
//                if (i.Size == Item)
//                    Console.Write(i + " ");
//            }
//            Console.Write("\n");
//        }
//    }
//    public partial class Test
//    {
//        private int _size;
//        public int Size
//        {
//            get { return _size; }
//            set { _size = value; }
//        }
//    }
//    #endregion
//}


//    #region Exam
//    public partial class Exam
//    {
//public List<Subject> SubList
//{ get; set; }

//public Exam(List<Subject> SubList)
//{
//    this.SubList = SubList;
//}

//public void AddItem(Subject item)
//{
//    SubList.Add(item);
//}
//public void RemoveItem(Subject item)
//{
//    SubList.Remove(item);
//}
//public void Show()
//{
//    foreach (Subject item in SubList)
//    {
//        Console.Write(item.Subj + " ");
//    }
//    Console.Write("\n");
//}
//}
//public class Subject
//{
//    private string _subj;
//    public string Subj
//    {
//        get { return _subj; }
//        set { _subj = value; }
//    }
//}
//#endregion
//}
