using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        enum Numbers
        {
            Lab = 6,
            Group,
            Course = 2
        }
        struct Number
        {
            public int N;
            public int G;
            public int C;
        }
        static void Main(string[] args)
        {
           
            #region Laba 5
            Number Num;
            Num.N = (int)Numbers.Lab;
            Num.G = (int)Numbers.Group;
            Num.C = (int)Numbers.Course;

            Console.WriteLine($"Лаб. раб. №{Num.N}.");
            Console.WriteLine($"Вариант {Num.G}.");
            Console.WriteLine($"{Num.G} группа.");
            Console.WriteLine($"{Num.C} курс.\n");

            #region Laba 14
            Question Vopros = new Question();
            BinaryFormatter binformatter = new BinaryFormatter();
            using (FileStream binfs = new FileStream("BinObj.dat", FileMode.OpenOrCreate))
            {
                binformatter.Serialize(binfs, Vopros);
                Console.WriteLine("Объект класса Question сериализован.");
            }
            using (FileStream binfs = new FileStream("BinObj.dat", FileMode.OpenOrCreate))
            {
                Question Vopros1 = (Question)binformatter.Deserialize(binfs);
                Console.WriteLine("Объект класса Question десериализован.\n\n");
                Vopros1.Quest = "Какой-то easy вопрос.";
                Vopros1.ToString();
                Vopros1.Do();
                Vopros1.GetOut();
                Console.WriteLine();
            }
            
            Test Test = new Test();
            SoapFormatter sformatter = new SoapFormatter();
            using (FileStream soapfs = new FileStream("SoapObj.dat", FileMode.OpenOrCreate))
            {
                sformatter.Serialize(soapfs, Test);
                Console.WriteLine("Объект класса Test сериализован.");
            }
            using (FileStream soapfs = new FileStream("SoapObj.dat", FileMode.OpenOrCreate))
            {
                Test Test0 = (Test)sformatter.Deserialize(soapfs);
                Console.WriteLine("Объект класса Test десериализован.\n\n");
                Test0.T();
                Test0.Testing = "Какой-то тест.";
                Test0.ToString();
                Test0.Do();
                Test0.GetOut();
                Console.WriteLine();
            }

            Exam Exam0 = new Exam();
            XmlSerializer xmlformatter = new XmlSerializer(typeof(Exam));
            using (FileStream xmlfs = new FileStream("XmlObj.dat", FileMode.OpenOrCreate))
            {
                sformatter.Serialize(xmlfs, Exam0);
                Console.WriteLine("Объект класса Exam сериализован.");
            }
            using (FileStream xmlfs = new FileStream("XmlObj.dat", FileMode.OpenOrCreate))
            {
                Exam Exam1 = (Exam)sformatter.Deserialize(xmlfs);
                Console.WriteLine("Объект класса Exam десериализован.\n\n");
                Exam1.E();
                Exam1.Examin = "Какой-то экзамен.";
                Exam1.ToString();
                Exam1.Do();
                Exam1.GetOut();
                Console.WriteLine();
            }

            FinalExam FinEx0 = new FinalExam();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(FinalExam));

            using (FileStream jsonfs = new FileStream("FinalExam.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(jsonfs, FinEx0);
                Console.WriteLine("Объект класса FinalExam сериализован.");
            }

            using (FileStream jsonfs = new FileStream("FinalExam.json", FileMode.OpenOrCreate))
            {
                FinalExam FinEx1 = (FinalExam)jsonFormatter.ReadObject(jsonfs);
                Console.WriteLine("Объект класса FinalExam десериализован.\n\n");
                FinEx1.FE();
                FinEx1.Final = "Какой-то выпускной экзамен.";
                FinEx1.ToString();
                FinEx1.Do();
                FinEx1.GetOut();
                Console.WriteLine();
            }
            

            ArrayList objectList = new ArrayList() { 1, 2, 5, 10, "Array", "List" };
            DataContractJsonSerializer collect = new DataContractJsonSerializer(typeof(ArrayList));
            using (FileStream fs = new FileStream("ArrayList.json", FileMode.OpenOrCreate))
            {
                collect.WriteObject(fs, objectList);
            }
            using (FileStream fs = new FileStream("ArrayList.json", FileMode.OpenOrCreate))
            {
                ArrayList objects = (ArrayList)collect.ReadObject(fs);
                foreach (object o in objectList)
                {
                    Console.WriteLine(o);
                }
            }
            #endregion
            Console.ReadKey();
            #endregion
        }
    }
}