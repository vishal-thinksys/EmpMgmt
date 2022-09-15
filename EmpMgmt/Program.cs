// See https://aka.ms/new-console-template for more information
using EmpMgmt;
using EmpMgmt.Entity;
using System.Drawing;

Console.WriteLine("Welcome to Employee Management System!");
//Console.WriteLine("Press 1 for Add New Employee");
//Console.WriteLine("Press 2 for Update Employee Detail");
Console.WriteLine("Press 1 for Show All Employee");

//Console.WriteLine("Press 4 for Show Employee Detail");
Console.Write("Please Enter the Number\t");
int n;
bool isNumerical = int.TryParse(Console.ReadLine(), out n);
n = isNumerical ? n : 0;

while (n > 0)
{
    switch (n)
    {
        case 1:
            List<Employee> list = EmployeeMethod();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("ID    =" + list[i].EmpID);
                Console.WriteLine("Name  =" + list[i].Name);
                Console.WriteLine("DOB   =" + list[i].DOB.ToString());
                Console.WriteLine("Email =" + list[i].EmailId);
                Console.WriteLine("Mobile=" + list[i].MobileNo);
                Console.WriteLine("");
            }
            Console.WriteLine("Are you search employee by Employee ID Press 11");
            isNumerical = int.TryParse(Console.ReadLine(), out n);
            n = isNumerical ? n : 0;
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
                    Console.WriteLine("ID    =" + lists[i].EmpID);
                    Console.WriteLine("Name  =" + lists[i].Name);
                    Console.WriteLine("DOB   =" + lists[i].DOB.ToString());
                    Console.WriteLine("Email =" + lists[i].EmailId);
                    Console.WriteLine("Mobile=" + lists[i].MobileNo);
                    Console.WriteLine("");
                    break;
                }
                else if (i== lists.Count-1)
                {
                    Console.Write("\nPlease Enter Correct Employee ID\n");
                    break;
                }

            }
            break;
        default:
            Console.WriteLine("\nPlease enter correct key");
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