using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace _10_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("1. Find files \n2. Compress files\n3. Decompress files\n4. Open files");
            int iii;
            while(!int.TryParse(Console.ReadLine(),out iii)) { Console.WriteLine("Try again"); }
            switch (iii)
            {
                case 1:
                    {
                        Console.WriteLine("We found the following HD:");
                        foreach (var item in GetDrivers())
                        {
                            Console.WriteLine(item.Name);
                        }
                        Console.WriteLine("Select folder for searching");
                        string path = Console.ReadLine();
                        Console.WriteLine("Select file (with file extension)");
                        string name = Console.ReadLine();
                        Console.WriteLine("File in: \n" +( FindFile(path,name) ?? "NotFound"));
                    }
                    Console.ReadKey();
                    return;
                case 2:
                    {
                        Console.WriteLine("Select path to source file");
                        string SourcePath = Console.ReadLine();
                        Console.WriteLine("Select path to output file");
                        string CompressedPath = Console.ReadLine();
                        Compress(SourcePath,CompressedPath);
                    }
                    Console.ReadKey();
                    return;
                case 3:
                    {
                        Console.WriteLine("Select path to source file");
                        string SourcePath = Console.ReadLine();
                        Console.WriteLine("Select path to output file");
                        string CompressedPath = Console.ReadLine();
                        Decompress(SourcePath, CompressedPath);
                    }
                    Console.ReadKey();
                    return;
                case 4:
                    {
                        Console.WriteLine("Select path");
                        string SourcePath = Console.ReadLine();
                        Console.WriteLine("Select file");
                        string FilePath = Console.ReadLine();
                        OpenFile(SourcePath);
                    }
                    Console.ReadKey();
                    return;
            }
            Console.WriteLine("Command not found");

           // OpenFile(@"D:\\MyFile.txt");

            // Console.WriteLine("Your file is here: " + FindFile(GetDrivers()[1].RootDirectory.ToString() ?? "NotFound", file));
           // Compress(@"D:\\MyFile.txt", @"D:\\MyTopFile.gz");
          //  Decompress(@"D:\\MyTopFile.gz", @"D:\\MyDecompressedFile.txt");

            Console.ReadKey();
        }

        #region Files
        static DriveInfo[] GetDrivers()
        {
            DriveInfo[] di = DriveInfo.GetDrives();
            DriveInfo[] drivers;
            int i = 0;
            foreach (DriveInfo d in di)
            {
                if (d.IsReady)
                    i++;
            }
            drivers = new DriveInfo[i];
            i = 0;
            foreach (DriveInfo d in di)
            {
                if (d.IsReady)
                {
                    drivers[i] = d;
                    i++;
                }

            }
            return drivers;
        }
        static string FindFile(string Path, string Name)
        {
            try
            {
               // Console.WriteLine(Path);
                if (FileIsExist(Path, Name))
                    return Path;
                else
                {
                    string[] A = Directory.GetDirectories(Path);
                    foreach (var a in A)
                    {
                        if (FindFile(a, Name) != null)
                            return a;
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
                
        }
        static bool FileIsExist(string Path, string Name)
        {
            try
            {
                string[] Files = Directory.GetFiles(Path);
                string H = Path + "\\" + Name;
                foreach (string file in Files)
                {
                    if (file == H)
                        return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        #endregion

        #region Compression
        static void Compress(string Source, string NewFile)
        {
            using (FileStream sourceStream = new FileStream(Source, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(NewFile))
                {
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                        Console.WriteLine(
                            $"Сжатие файла {Source}" +
                            $" завершено. Исходный размер: {sourceStream.Length.ToString()}" +
                            $"  сжатый размер: {targetStream.Length.ToString()}.");
                    }
                }
            }        
        }
        static void Decompress(string Source, string NewFile)
        {
            using (FileStream sourceStream = new FileStream(Source, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(NewFile))
                {
                    using (GZipStream compressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        compressionStream.CopyTo(targetStream);
                        Console.WriteLine(
                            $"Восстановление файла {Source}" +
                            $" завершено. Исходный размер: {sourceStream.Length.ToString()}" +
                            $"  восстановленый размер: {targetStream.Length.ToString()}.");
                    }
                }
            }

        }
        #endregion

        #region FileWatcher
        static void OpenFile(string Path)
        {
            try
            {
                using (FileStream FS = File.OpenRead(Path))
                {
                    byte[] Array = new byte[FS.Length];
                    FS.Read(Array, 0, Array.Length);
                    string a = System.Text.Encoding.Default.GetString(Array);
                    Console.WriteLine(a);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        #endregion
    }
}
