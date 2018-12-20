using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace lab13C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра FileSystemWatcher для наблюдения за определенным директорием
            Thread thread = new Thread(LMVLog.Start);
            thread.Start();

            LMVDiskInfo.FreeSpace("D:\\");
            LMVDiskInfo.FileSystemInfo("D:\\");
            LMVDiskInfo.DrivesFullInfo();

            LMVFileInfo.FullPath(@"D:\Std\MS\Lb13\IMG.jpg");
            LMVFileInfo.BasicFileInfo(@"D:\Std\MS\Lb13\IMG.jpg");
            LMVFileInfo.CreationTime(@"D:\Std\MS\Lb13\IMG.jpg");

            LMVDirInfo.FileCount(@"D:\Std\MS\Lb13");
            LMVDirInfo.CreationTime(@"D:\Std\MS\Lb13");
            LMVDirInfo.SubdirectoriesCount(@"D:\Std\MS\Lb13");
            LMVDirInfo.ParentDirectory(@"D:\Std\MS\Lb13");

            LMVFileManager.InspectDrive(@"D:\");
            LMVFileManager.CopyFiles(@"D:\Std\MS\Lb13", @"D:\Std\MS\Lb13");
            LMVFileManager.ArchiveUnarchive();

            // Остановка процесса наблюдения
            thread.Abort();

            Console.WriteLine("Удалить каталоги? 1 - да,(0,2-255)-нет");
            int key = int.Parse(Console.ReadLine());
            if (key == 1)
            {
                System.IO.Directory.Delete(@"D:\Std\MS\Lb13\LMVInspect", true);
                System.IO.Directory.Delete(@"D:\Std\MS\Lb13\Unzipped", true);
            }

            LMVLog.SearchByDate("20.12.2018");
            Console.ReadLine();
        }
    }
}
