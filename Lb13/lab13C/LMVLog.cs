using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab13C
{
    class LMVLog
    {
        // Создание экземпляра FileSystemWatcher для наблюдения
        static FileSystemWatcher watcher = new FileSystemWatcher
        {
            Path = @"D:\Std\MS\Lb13",
            IncludeSubdirectories = true,
            NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName
        };
        // Начинает слежение за изменениями и фиксирует их путём вызова обработчика события
        public static void Start()
        {
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        public static void SearchByDate(string date)
        {
            watcher.EnableRaisingEvents = false;
            using (StreamReader sr = new StreamReader(@"D:\Std\MS\Lb13\LMVlog.txt"))
            {
                while (!sr.EndOfStream)
                {
                    if (sr.ReadLine().StartsWith(date))
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File " + e.ChangeType + " " + e.FullPath);

            using (StreamWriter logfile = new StreamWriter(@"D:\Std\MS\Lb13\LMVlog.txt", true))
            {
                logfile.WriteLine(DateTime.Now + "   " + e.ChangeType + "    путь: " + e.FullPath);
            }
        }
    }
}
