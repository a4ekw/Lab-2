using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab13C
{
    static class LMVDirInfo
    {
        public static void FileCount(string path)
        {
            Console.WriteLine("Количество файлов в каталоге {0}: {1}", path, Directory.GetFiles(path).Length);
            Console.WriteLine();
        }

        public static void CreationTime(string path)
        {
            Console.WriteLine("Время создания каталога {0}: {1}", path, Directory.GetCreationTime(path));
            Console.WriteLine();
        }

        public static void SubdirectoriesCount(string path)
        {
            Console.WriteLine("Количество подкаталогов в каталоге {0}: {1}", path, Directory.GetDirectories(path).Length);
            Console.WriteLine();
        }

        public static void ParentDirectory(string path)
        {
            Console.WriteLine("Родительский каталог каталога {0}: {1}", path, Directory.GetParent(path));
            Console.WriteLine();
        }
    }
}
