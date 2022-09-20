using EmpMgmt.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void ConvertListToJson()
        {

            if (!File.Exists(fileName))
            {
                //CreateFile();
                EmployeeList employeeList = new EmployeeList();
                List<Employee> employees = employeeList.All_Employee();
                string serializedJson = JsonConvert.SerializeObject(employees,Formatting.Indented);
                //File.WriteAllText(fileName,serializedJson);
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(serializedJson);
                    }
                }
            }
        }
        public void ConvertJsonToList()
        {
            if (File.Exists(fileName))
            {
                //string line = "";
                string Json =File.ReadAllText(fileName);
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
    }
}
