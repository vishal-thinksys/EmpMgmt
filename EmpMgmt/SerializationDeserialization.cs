using EmpMgmt.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmpMgmt
{
    public class SerializationDeserialization
    {
        string fileName;
        public SerializationDeserialization()
        {
            string folderName = @"C:\Users\kumar.vishal\Desktop\Vishal\EmpMgmt\EmpMgmt";
            fileName = Path.Combine(folderName, "JSONFile.json");
        }
        public void CreateFile()
        {

            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }
       
        public void ConvertJsonToList()
        {
            if (File.Exists(fileName))
            {
                //string line = "";
                string Json = File.ReadAllText(fileName);
                //using (StreamReader sr = new StreamReader(fileName))
                //{
                //    while ((line=sr.ReadLine()) != null)
                //    {
                //        Json += line;
                //    }
                //}
                List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(Json);
                PrintList.PrintDetail(emp);
            }
            else
            {
                Console.WriteLine("Json File does not exist!");
            }
        }
        
       
        public void StringReplaceInJson(string Oldtext, string Newtext)
        {
            string text = File.ReadAllText(fileName);
            text = text.Replace(Oldtext, Newtext);
            File.WriteAllText(fileName, text);
        }
    }
}
