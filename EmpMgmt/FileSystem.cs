using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    public class FileSystem
    {
        string fileName;
        public FileSystem()
        {
            string folderName = @"C:\Users\kumar.vishal\Desktop\Vishal\EmpMgmt";
            fileName = Path.Combine(folderName, "Text.txt");
        }
        public void CreateFile()
        {
            
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }           
            //Directory.CreateDirectory(fileName);
        }
        public void InsertDataInFile()
        {
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine($"Date {DateTime.Now}");
                        sw.WriteLine("\nMy name is Vishal Kumar.");
                        sw.WriteLine("\nMy name is Vishal Kumar.");
                        sw.WriteLine("\nMy name is Vishal Kumar.");
                        sw.WriteLine("\nMy name is Vishal Kumar.");
                    }
                }
            }
        }
        public void ReadDataFromFile()
        {
            if (File.Exists(fileName))
            {
                string line = "";
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }  
        public void StringReplaceInFile(string Oldtext,string Newtext)
        {
            string text = File.ReadAllText(fileName);
            text = text.Replace(Oldtext, Newtext);
            File.WriteAllText(fileName, text);
        }
    }
}
