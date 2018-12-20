using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace lab13C
{
    static class LMVFileManager
    {
        // Записывает в txt файл содержимое 1-ого уровня указанного диска
        public static void InspectDrive(string driveName)
        {
            DirectoryInfo dir = new DirectoryInfo(driveName);
            FileInfo[] file = dir.GetFiles();

            Directory.CreateDirectory(@"D:\Std\MS\Lb13\LMVInspect");

            using (StreamWriter saveinf = new StreamWriter(@"D:\Std\MS\Lb13\LMVInspect\LMVdirinfo.txt"))
            {
                foreach (DirectoryInfo d in dir.GetDirectories())
                    saveinf.WriteLine(d.Name);
                foreach (FileInfo f in file)
                    saveinf.WriteLine(f.Name);
            }
            try { 
            File.Copy(@"D:\lab13\LMVInspect\LMVdirinfo.txt", @"D:\Std\MS\Lb13\LMVInspect\LMVdirinfo_renamed.txt");
            }
            catch { }
            File.Delete(@"D:\Std\MS\Lb13\LMVInspect\LMVdirinfo.txt");
        }

        /// Создает папку CMAFiles, копирует в нее файлы из заданного пути по заданному расширению и перемещает папку в CMAFiles
        public static void CopyFiles(string path, string ext)
        {
            string dirpath = @"D:\Std\MS\Lb13\LMVFiles";
            Directory.CreateDirectory(dirpath);
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Extension == ext)
                    file.CopyTo($@"{dirpath}\{file.Name}");
            }
            try { 
            Directory.Move(@"D:\Std\MS\Lb13\LMVFiles", @"D:\Std\MS\Lb13\LMVInspect\LMVFiles");
            }
            catch { }
        }

        // Архивация и разархивация
        public static void ArchiveUnarchive()
        {
            string dirpath = @"D:\Std\MS\Lb13\LMVInspect\LMVFiles";
            string zippath = @"D:\Std\MS\Lb13\LMVInspect\LMVFiles.zip";
            string unzippath = @"D:\Std\MS\Lb13\";
            try { 
            ZipFile.CreateFromDirectory(dirpath, zippath);
            }
            catch
            {
                File.Delete(zippath);
                try { ZipFile.CreateFromDirectory(dirpath, zippath); }
                catch { }
            }
            try
            {
                ZipFile.ExtractToDirectory(zippath, unzippath);
            }
            catch
            {
                File.Delete(@"D:\Std\MS\Lb13\Unzipped");
                try
                {
                    ZipFile.ExtractToDirectory(zippath, unzippath);
                }
                catch { }
            }
        }
    }
}
