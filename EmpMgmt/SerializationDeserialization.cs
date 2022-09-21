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
                    Console.WriteLine("Press 5 for Salary");
                    Console.WriteLine("Press 6 for DOJ");
                    Console.WriteLine("Press 7 for Delete Employee record");
                    Console.WriteLine("Please Enter the number:");
                    int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
                    Employee empl;
                    //var setting = new JsonSerializerSettings() { DateFormatString = "dd MMMM yyyy" };                    
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Please Enter New Name:");
                            empl = emp.Where(x => x.EmpID == m).Select(y => { y.Name = Console.ReadLine() ?? ""; return y; }).FirstOrDefault();
                            ReWriteInJsonFile(Json, m, empl);

                            break;
                        case 2:
                            Console.WriteLine("Please Enter New DOB(dd-mm-yyyy):");
                            DateTime d;
                            if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d))
                            {
                                empl = emp.Where(x => x.EmpID == m).Select(y => { y.DOB = Convert.ToDateTime(d); return y; }).FirstOrDefault();
                                ReWriteInJsonFile(Json, m, empl);

                            }
                            else
                                Console.WriteLine("You are enter wrong Date");
                            break;
                        case 3:
                            Console.WriteLine("Please Enter New EmailId:");
                            string Email=Console.ReadLine().Trim();
                            if (Email.Length>0)
                            {
                                if (JsonConvert.DeserializeObject<List<Employee>>(Json).Where(x => x.EmailId.ToUpper() == Email.ToUpper()).ToList().Count == 0)
                                {
                                    empl = emp.Where(x => x.EmpID == m).Select(y => { y.EmailId = Email; return y; }).FirstOrDefault();
                                    ReWriteInJsonFile(Json, m, empl);
                                }
                                else
                                {
                                    Console.WriteLine("Email Already Exist!!!");
                                }
                            }
                            else
                                Console.WriteLine("You are not enter any email!");
                            break;
                        case 4:
                            Console.WriteLine("Please Enter New MobileNo:");
                            string mob = Console.ReadLine();
                            if (mob.Length == 10)
                            {
                                double r;
                                if (double.TryParse(mob, out r))
                                {
                                    if (JsonConvert.DeserializeObject<List<Employee>>(Json).Where(x=>x.MobileNo== mob).ToList().Count==0)
                                    {
                                        empl = emp.Where(x => x.EmpID == m).Select(y => { y.MobileNo = mob; return y; }).FirstOrDefault();
                                        ReWriteInJsonFile(Json, m, empl);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Mobile Number Already Exist!!!");
                                    }

                                }
                                else
                                    Console.WriteLine("Please Enter Valid Mobile No");
                            }
                            else
                                Console.WriteLine("Please Enter Valid Mobile No");
                            break;
                        case 5:
                            Console.WriteLine("Please Enter New Salary:");
                            string salary = Console.ReadLine();
                            double sal;
                            if (double.TryParse(salary, out sal))
                            {
                                empl = emp.Where(x => x.EmpID == m).Select(y => { y.Salary = sal; return y; }).FirstOrDefault();
                                ReWriteInJsonFile(Json, m, empl);

                            }
                            else
                                Console.WriteLine("Please Enter Valid Amount");
                            break;
                        case 6:
                            Console.WriteLine("Please Enter New DOJ (dd-mm-yyyy):");
                            DateTime dat;
                            if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dat))
                            {
                                empl = emp.Where(x => x.EmpID == m).Select(y => { y.DOJ = Convert.ToDateTime(dat); return y; }).FirstOrDefault();
                                ReWriteInJsonFile(Json, m, empl);
                            }
                            else
                                Console.WriteLine("You are enter wrong Date");
                            break;
                        case 7:
                            Console.WriteLine("Are you sure want to delete then press y");
                            if (Console.ReadLine() == "y")
                            {
                                empl = new Employee();
                                ReWriteInJsonFile(Json, m, empl);
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
            }
            else
            {
                Console.WriteLine("Json File does not exist!");
            }
        }
        void ReWriteInJsonFile(string Json, int id, Employee emp)
        {
            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(Json);
            employees = employees.Where(x => x.EmpID != id).ToList();
            if (emp.EmpID!=0)
                employees.Add(emp);
            employees = employees.OrderBy(X => X.EmpID).ToList();
            var setting = new JsonSerializerSettings() { DateFormatString = "dd MMMM yyyy" };
            string serializedJson = JsonConvert.SerializeObject(employees, Formatting.Indented, setting);
            using (FileStream fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(serializedJson);
                }
            }
            PrintList.PrintDetail(employees);
        }
        public void StringReplaceInJson(string Oldtext, string Newtext)
        {
            string text = File.ReadAllText(fileName);
            text = text.Replace(Oldtext, Newtext);
            File.WriteAllText(fileName, text);
        }
    }
}
