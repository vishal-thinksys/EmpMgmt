using EmpMgmt.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt.JsonUtility
{
    public class ShowEmpData
    {

        string fileName;
        public ShowEmpData()
        {
            string folderName = @"C:\Users\kumar.vishal\Desktop\Vishal\EmpMgmt\EmpMgmt";
            fileName = Path.Combine(folderName, "JSONFile.json");
        }
        public void ConvertJsonToList()
        {
            if (File.Exists(fileName))
            {
                string Json = File.ReadAllText(fileName);
                List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(Json);
                PrintList.PrintDetail(emp);
            }
            else
            {
                Console.WriteLine("Json File does not exist!");
            }
        }
    }
}
