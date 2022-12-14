// See https://aka.ms/new-console-template for more information
using EmpMgmt;
using EmpMgmt.Entity;
using System.Drawing;

Console.WriteLine("Welcome to Employee Management System!");
int n;
Comman_Command_Name();

while (n > 0)
{
    switch (n)
    {
        case 1:
            List<Employee> list = EmployeeMethod();
            for (int i = 0; i < list.Count; i++)
            {
                Employee emp = list[i];
                printDetail(emp);                
            }
            Comman_Command_Name();
            break;
        case 11:
            Console.Write("\nPlease Enter the Employee ID\t");
            int m;
            bool isNumericals = int.TryParse(Console.ReadLine(), out m);
            m = isNumericals ? m : 0;
            List<Employee> lists = EmployeeMethod();
            for (int i = 0; i < lists.Count; i++)
            {
                
                if (lists[i].EmpID == m)
                {

                    Employee emp = lists[i];
                    printDetail(emp);
                    break;
                }
                else if (i== lists.Count-1)
                {
                    
                    Console.Write("\nPlease Enter Correct Employee ID\n");
                    break;
                }

            }
            Comman_Command_Name();
            break;
        case 12:
            Console.Write("\nPlease Enter the Employee Name\t");
           
           string Name=Console.ReadLine();            
            List<Employee> listed = EmployeeMethod();
            int num = 0;
            for (int i = 0; i < listed.Count; i++)
            {               
                if (listed[i].Name.ToUpper().Trim() == Name.ToUpper().Trim())
                {
                    num = 1;
                    Employee emp = listed[i];
                    printDetail(emp);
                }
                else if (i == listed.Count - 1)
                {
                    if (num == 0)
                    {
                        Console.Write("\nPlease Enter Correct Employee Name\n");
                        break;
                    }                    
                }
            }
            Comman_Command_Name();
            break;
        default:
            Console.WriteLine("\nPlease enter correct key\n");
            n = 1;
            break;
    }
}
List<Employee> EmployeeMethod()
{
    List<Employee> employee = new List<Employee>();
    EmployeeList employeeList = new EmployeeList();
    return employeeList.All_Employee();
}
void Comman_Command_Name()
{
    Console.WriteLine("Press 1 for Show All Employee");
    Console.WriteLine("Are you search employee by Employee ID Press 11");
    Console.WriteLine("Are you search employee by Employee Name Press 12");
    Console.Write("Please Enter the Number\t");
    bool isNumerical = int.TryParse(Console.ReadLine(), out n);
    n = isNumerical ? n : 0;
}
void printDetail(Employee emp)
{
    Console.WriteLine("ID    =" + emp.EmpID);
    Console.WriteLine("Name  =" + emp.Name);
    Console.WriteLine("DOB   =" + emp.DOB.ToString());
    Console.WriteLine("Email =" + emp.EmailId);
    Console.WriteLine("Mobile=" + emp.MobileNo);
    Console.WriteLine("Salary =" + emp.Salary.ToString());
    Console.WriteLine("Date of Joinning=" + emp.DOJ.ToString());
    Console.WriteLine("");
}