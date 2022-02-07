using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.WorkingWithFiles
{
    public class DirAndFiles
    {
        public void Dir(string path, string newDir)
        {
            if (Directory.Exists(path))
            {
                Directory.CreateDirectory(path + "/" + newDir);
                //System.IO.File.Create(path + "/" + newDir + "/" + "TestFile.txt");
            }
            else
            {
                Console.WriteLine("К  ожалению нет такого каталога:" + path);
            }

        }

        public void CreateTxtFile1(string path, string newDir, string NameFile)
        {
            if (Directory.Exists(path))
            {
                System.IO.File.Create(path + "/" + newDir + "/" + NameFile);
            }
        }

        public static void CreateTxtFile(string path, string newDir, string NameFile)
        {
            if (Directory.Exists(path))
            {
                System.IO.File.Create(path + "/" + newDir + "/" + NameFile);
            }
                
        }

        public static void CreateDocFile(string path, string newDir, string NameFile)
        {
            if (Directory.Exists(path))
            {
                System.IO.File.Create(path + "/" + newDir + "/" + NameFile);
            }
        }

        public static void CreateExlFile(string path, string newDir, string NameFile)
        {
            if (Directory.Exists(path))
            {
                System.IO.File.Create(path + "/" + newDir + "/" + NameFile);
            }
                
        }
    }
}
