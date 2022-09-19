// See https://aka.ms/new-console-template for more information
using EmpMgmt;
using EmpMgmt.Entity;


Console.WriteLine("Welcome to Employee Management System!");
int n;
CommanCommandName();

while (n > 0)
{
    switch (n)
    {
        case 1:
            List<Employee> list = EmployeeMethod();
            PrintDetail(list);
            CommanCommandName();
            break;
        case 11:
            Console.Write("\nPlease Enter the Employee ID\t");
            int m = int.TryParse(Console.ReadLine(), out m) ? m : 0;
            List<Employee> lists = EmployeeMethod();
            lists = lists.Where(x => x.EmpID == m).ToList();
            if (lists.Count > 0)
            {
                PrintDetail(lists);
            }
            else
            {
                Console.Write("\nPlease Enter Correct Employee ID\n");
                break;
            }
            //for (int i = 0; i < lists.Count; i++)
            //{

            //    if (lists[i].EmpID == m)
            //    {

            //        Employee emp = lists[i];

            //        break;
            //    }
            //    else if (i== lists.Count-1)
            //    {


            //    }

            //}
            CommanCommandName();
            break;
        case 12:
            Console.Write("\nPlease Enter the Employee Name\t");

            string Name = Console.ReadLine();
            List<Employee> listed = EmployeeMethod();
            listed = listed.Where(x => x.Name.ToUpper().Trim() == Name.ToUpper().Trim()).ToList();
            if (listed.Count > 0)
            {
                PrintDetail(listed);
            }
            else
            {
                Console.Write("\nPlease Enter Correct Employee Name\n");
                break;
            }
            //int num = 0;

            //for (int i = 0; i < listed.Count; i++)
            //{               
            //    if (listed[i].Name.ToUpper().Trim() == Name.ToUpper().Trim())
            //    {
            //        num = 1;
            //        Employee emp = listed[i];
            //        PrintDetail(emp);
            //    }
            //    else if (i == listed.Count - 1)
            //    {
            //        if (num == 0)
            //        {
            //            Console.Write("\nPlease Enter Correct Employee Name\n");
            //            break;
            //        }                    
            //    }
            //}
            CommanCommandName();
            break;
        case 101:
            Console.Write("\nPlease Enter Radius:\t");
            double rad = double.TryParse(Console.ReadLine(), out rad) ? rad : 0;
            InterfacePractice ip = new InterfacePractice();
            ip.CircleArea(rad);
            CommanCommandName();
            break;
        case 102:
            Console.Write("\nPlease Enter Length of Rectangle:\t");
            double len = double.TryParse(Console.ReadLine(), out len) ? len : 0;
            Console.Write("\nPlease Enter breadth of Rectangle:\t");
            double br = double.TryParse(Console.ReadLine(), out br) ? br : 0;
            InterfacePractice ipr = new InterfacePractice();
            ipr.RectangleArea(len, br);
            CommanCommandName();
            break;
        case 103:
            Console.Write("\nPlease Enter Height of Triangle:\t");
            double He = double.TryParse(Console.ReadLine(), out He) ? He : 0;
            Console.Write("\nPlease Enter width of Triangle:\t");
            double wi = double.TryParse(Console.ReadLine(), out wi) ? wi : 0;
            InterfacePractice ipt = new InterfacePractice();
            ipt.TriangleArea(He, wi);
            CommanCommandName();
            break;
        case 104:
            IMovement ani = new Cat();
            ani.Move();
            IMakeSound animal = new Cat();
            animal.MakeSound();
            IAnimal2 animal2 = new Cat();
            animal2.SpeciesName = "hello";
            Console.WriteLine(animal2.SpeciesName);
            CommanCommandName();
            break;
        case 105:
            AbstractClass abstractClass = new AbstractClass();
            abstractClass.CallAbstractClass();
            CommanCommandName();
            break;
        case 106:
            Console.Write("\nPlease Enter the Text for Find Repeated Character:\t");
            string text = Console.ReadLine();
            DictonaryUse dictonaryUse = new DictonaryUse();
            dictonaryUse.CountRepeatedChar(text);
            CommanCommandName();
            break;
        case 107:
            FileSystem fileSystem = new FileSystem();
            fileSystem.CreateFile();
            fileSystem.InsertDataInFile();
            fileSystem.ReadDataFromFile();
            fileSystem.StringReplaceInFile("Vishal","Rohan");
            CommanCommandName();
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
void CommanCommandName()
{
    Console.WriteLine("");
    Console.WriteLine("Press 1 for Show All Employee");
    Console.WriteLine("Are you search employee by Employee ID Press 11");
    Console.WriteLine("Are you search employee by Employee Name Press 12");
    Console.WriteLine("Calculate Area of Circle Press 101");
    Console.WriteLine("Calculate Area of Rectangle Press 102");
    Console.WriteLine("Calculate Area of Triangle Press 103");
    Console.WriteLine("Multiple Inheritance Code Run for Press 104");
    Console.WriteLine("Abstract class Code Run for Press 105");
    Console.WriteLine("Find the repeated charater of string for Press 106");
    Console.WriteLine("For file System Press 107");
    Console.Write("Please Enter the Number\t");
    bool isNumerical = int.TryParse(Console.ReadLine(), out n);
    n = isNumerical ? n : 0;
}
void PrintDetail(List<Employee> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"ID    ={list[i].EmpID}");
        Console.WriteLine($"Name  ={list[i].Name}");
        Console.WriteLine($"DOB   ={list[i].DOB.ToString()}");
        Console.WriteLine($"Email ={list[i].EmailId}");
        Console.WriteLine($"Mobile={list[i].MobileNo}");
        Console.WriteLine($"Salary={list[i].Salary.ToString()}");
        Console.WriteLine($"Date of Joinning={list[i].DOJ}");
        Console.WriteLine("");
    }

}
