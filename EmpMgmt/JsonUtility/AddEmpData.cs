using EmpMgmt.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt.JsonUtility
{
    public class AddEmpData
    {
        string fileName;
        public AddEmpData()
        {
            string folderName = @"C:\Users\kumar.vishal\Desktop\Vishal\EmpMgmt\EmpMgmt";
            fileName = Path.Combine(folderName, "JSONFile.json");
        }
        public void ConvertListToJson()
        {

            if (!File.Exists(fileName))
            {
                
                EmployeeList employeeList = new EmployeeList();
                List<Employee> employees = employeeList.All_Employee();               
                var setting = new JsonSerializerSettings() { DateFormatString = "MM'-'dd'-'yyyy" };
                string serializedJson = JsonConvert.SerializeObject(employees, Formatting.Indented, setting);               
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(serializedJson);
                    }
                }
            }
        }
        public void AddNewEmpDetailInJsonFile()
        {

            if (File.Exists(fileName))
            {
                bool temp;
                string Json = File.ReadAllText(fileName);
                List<Employee> list = JsonConvert.DeserializeObject<List<Employee>>(Json) ?? new List<Employee>();                
                list = list.OrderBy(X => X.EmpID).ToList();
                int count=list.Count();
                Employee emp = new Employee();
                emp.EmpID = list[count - 1].EmpID+1;
                do
                {
                    Console.WriteLine("Please Enter Employee Name:\t");
                    emp.Name = Console.ReadLine() ?? "";
                } while (emp.Name=="");               
                do
                {
                    temp = true;
                    Console.WriteLine("Please Enter Employee DOB (dd-mm-yyyy):\t");
                    DateTime dat;
                    if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dat))
                    {
                        temp = false;
                        emp.DOB = dat;
                    }
                } while (temp);
                do
                {
                    Console.WriteLine("Please Enter Employee EmailId:\t");
                    emp.EmailId = Console.ReadLine() ?? "";
                } while (emp.EmailId == "");
                do
                {
                    temp = true;
                    Console.WriteLine("Please Enter Employee MobileNo:\t");
                    string mob = Console.ReadLine() ?? "";
                    if (mob.Length == 10)
                    {
                        double r;
                        if (double.TryParse(mob, out r))
                        {
                            if (JsonConvert.DeserializeObject<List<Employee>>(Json).Where(x => x.MobileNo == mob).ToList().Count == 0)
                            {
                                temp = false;
                                emp.MobileNo = mob;
                            }
                        }
                    }
                } while (temp);
                do
                {
                    temp = true;
                    Console.WriteLine("Please Enter Employee Salary:\t");
                    string salary = Console.ReadLine() ?? "";
                    double sal;
                    if (double.TryParse(salary, out sal))
                    {
                        temp = false;
                        emp.Salary = sal;
                    }
                } while (temp);
                do
                {
                    temp = true;
                    Console.WriteLine("Please Enter Employee DOJ (dd-mm-yyyy):\t");
                    DateTime dat;
                    if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dat))
                    {
                        temp = false;
                        emp.DOJ = dat;
                    }                    
                } while (temp);
                list.Add(emp);
                var setting = new JsonSerializerSettings() { DateFormatString = "MM'-'dd'-'yyyy" };
                string serializedJson = JsonConvert.SerializeObject(list, Formatting.Indented, setting);
                using (FileStream fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(serializedJson);
                    }
                }
                ShowEmpData showEmp = new ShowEmpData();
                showEmp.ConvertJsonToList();
            }
            else
            {
                Console.WriteLine("Json File does not exist!");
            }
        }

    }
}
