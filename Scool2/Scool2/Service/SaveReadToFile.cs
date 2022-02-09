using School.DataAccess;
using School.Entity;
using School.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service
{
    public class SaveReadToFile : ISaveReadToFile
    {
        private List<MySchool> MyDBContext;

        public string AllSpisok;
        public string textFromFile;
        public SaveReadToFile()
        {
                MyDBContext = Singleton.GetInstance.Data;
        }
        
        public void SaveToFile()
        {
            var SpisokStudents = MyDBContext.SelectMany(q => q.MyClasses).SelectMany(w => w.MyListStudent).Select(e => e.Name).ToList();

            int i = 0;
            foreach (var s in SpisokStudents)
            {
                AllSpisok = AllSpisok + SpisokStudents[i]+" , ";
                i++;
            };
            
            using (FileStream fs = new FileStream("D:\\1\\SpisokStudents.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(AllSpisok);
                fs.Write(array, 0, array.Length);
                //fs.Close();
            }
        }

        public void ReadFromFile()
        {
            using (FileStream fstream = File.OpenRead("D:\\1\\SpisokStudents.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                textFromFile = System.Text.Encoding.Default.GetString(array);
            }
        }

        public void VerifyData()
        {
            Console.WriteLine("Список для записи в файл:");
            Console.WriteLine(AllSpisok);
            Console.WriteLine();
            Console.WriteLine("Список полученных из файла данных:");
            Console.WriteLine(textFromFile);
            Console.WriteLine();
            if (AllSpisok == textFromFile)
            {
                Console.WriteLine("Записи совпадают");
            }
            else
            {
                Console.WriteLine("Записи НЕ совпадают");
            }
        }

    }
}
