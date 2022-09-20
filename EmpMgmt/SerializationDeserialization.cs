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
        public void ConvertListToJson()
        {

            if (!File.Exists(fileName))
            {
                //CreateFile();
                EmployeeList employeeList = new EmployeeList();
                List<Employee> employees = employeeList.All_Employee();
                //employees= employees.Where(x=>x.DOB=(string)x.DOB.ToString("dd MMMM yyyy"))
                //employees.Select(x => x.DOB.ToLongDateString()).ToList();
                //employees.Select(y => y.DOJ.ToLongDateString()).ToList();
                var setting = new JsonSerializerSettings() { DateFormatString = "dd MMMM yyyy" };
                string serializedJson = JsonConvert.SerializeObject(employees, Formatting.Indented, setting);
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
        public void UpdateEmployeeDetail()
        {
            if (File.Exists(fileName))
            {

                string Json = File.ReadAllText(fileName);
                List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(Json);
                Console.WriteLine("Please Enter EmpID Which you want to update:");
                int m = int.TryParse(Console.ReadLine(), out m) ? m : 0;
                emp = emp.Where(x => x.EmpID == m).ToList();
                if (emp.Count > 0)
                {
                    PrintList.PrintDetail(emp);
                    Console.WriteLine("Press 1 for Name");
                    Console.WriteLine("Press 2 for DOB");
                    Console.WriteLine("Press 3 for EmailId");
                    Console.WriteLine("Press 4 for MobileNo");
                    Console.WriteLine("Press 5 for Delete Employee record");
                    //Console.WriteLine("Press 5 for Salary");
                    //Console.WriteLine("Press 6 for DOJ");
                    Console.WriteLine("Please Enter the number:");
                    int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
                    var setting = new JsonSerializerSettings() { DateFormatString = "dd MMMM yyyy" };                    
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Please Enter New Name:");
                            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(Json);
                            employees = employees.Where(x => x.EmpID != m).ToList();
                            Employee empl = emp.Where(x => x.EmpID == m).Select(y => { y.Name = Console.ReadLine() ?? ""; return y; }).ToList().FirstOrDefault();
                            employees.Add(empl);
                            employees = employees.OrderBy(X => X.EmpID).ToList();  
                            string serializedJson = JsonConvert.SerializeObject(employees, Formatting.Indented, setting);
                            using (FileStream fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
                            {
                                using (StreamWriter sw = new StreamWriter(fs))
                                {
                                    sw.WriteLine(serializedJson);
                                }
                            }
                            PrintList.PrintDetail(employees);
                            break;
                        case 2:
                            Console.WriteLine("Please Enter New DOB(dd-mm-yyyy):");
                            DateTime d;
                            if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d))
                            {
                                List<Employee> employees2 = JsonConvert.DeserializeObject<List<Employee>>(Json);
                                employees2 = employees2.Where(x => x.EmpID != m).ToList();
                                Employee empl2 = emp.Where(x => x.EmpID == m).Select(y => { y.DOB = Convert.ToDateTime(d); return y; }).ToList().FirstOrDefault();
                                employees2.Add(empl2);
                                employees2 = employees2.OrderBy(X => X.EmpID).ToList();
                                string serializedJson2 = JsonConvert.SerializeObject(employees2, Formatting.Indented, setting);
                                using (FileStream fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
                                {
                                    using (StreamWriter sw = new StreamWriter(fs))
                                    {
                                        sw.WriteLine(serializedJson2);
                                    }
                                }
                                PrintList.PrintDetail(employees2);
                            }
                            else
                                Console.WriteLine("You are enter wrong Date");
                            break;
                        case 3:
                            Console.WriteLine("Please Enter New EmailId:");
                            List<Employee> employees3 = JsonConvert.DeserializeObject<List<Employee>>(Json);
                            employees3 = employees3.Where(x => x.EmpID != m).ToList();
                            Employee empl3 = emp.Where(x => x.EmpID == m).Select(y => { y.EmailId = Console.ReadLine() ?? ""; return y; }).ToList().FirstOrDefault();
                            employees3.Add(empl3);
                            employees3 = employees3.OrderBy(X => X.EmpID).ToList();
                            string serializedJson3 = JsonConvert.SerializeObject(employees3, Formatting.Indented, setting);
                            using (FileStream fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
                            {
                                using (StreamWriter sw = new StreamWriter(fs))
                                {
                                    sw.WriteLine(serializedJson3);
                                }
                            }
                            PrintList.PrintDetail(employees3);
                            break;
                        case 4:
                            Console.WriteLine("Please Enter New MobileNo:");
                            string mob = Console.ReadLine();
                            if (mob.Length == 10)
                            {
                                double r;
                                if (double.TryParse(mob, out r))
                                {
                                    List<Employee> employees4 = JsonConvert.DeserializeObject<List<Employee>>(Json);
                                    employees4 = employees4.Where(x => x.EmpID != m).ToList();
                                    Employee empl4 = emp.Where(x => x.EmpID == m).Select(y => { y.MobileNo = mob; return y; }).ToList().FirstOrDefault();
                                    employees4.Add(empl4);
                                    employees4 = employees4.OrderBy(X => X.EmpID).ToList();
                                    string serializedJson4 = JsonConvert.SerializeObject(employees4, Formatting.Indented, setting);
                                    using (FileStream fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
                                    {
                                        using (StreamWriter sw = new StreamWriter(fs))
                                        {
                                            sw.WriteLine(serializedJson4);
                                        }
                                    }
                                    PrintList.PrintDetail(employees4);
                                }
                                else
                                    Console.WriteLine("Please Enter Valid Mobile No");
                            }
                            else
                                Console.WriteLine("Please Enter Valid Mobile No");
                            break;
                        case 5:
                            Console.WriteLine("Are you sure want to delete then press y");
                            if (Console.ReadLine()=="y")
                            {
                                List<Employee> employees5 = JsonConvert.DeserializeObject<List<Employee>>(Json);
                                employees5 = employees5.Where(x => x.EmpID != m).ToList();
                                string serializedJson5 = JsonConvert.SerializeObject(employees5, Formatting.Indented, setting);
                                using (FileStream fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
                                {
                                    using (StreamWriter sw = new StreamWriter(fs))
                                    {
                                        sw.WriteLine(serializedJson5);
                                    }
                                }
                                PrintList.PrintDetail(employees5);
                            }
                            else
                                Console.WriteLine("You are enter wrong key");
                            break;
                        default:
                            Console.WriteLine("You are enter Wrong Number");
                            break;
                    }


                }
                else
                    Console.WriteLine($"EmpID {m} does not exist in the Json file ");
                //PrintList.PrintDetail(emp);
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
