using EmpMgmt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    public class EmployeeList
    {
        public List<Employee> All_Employee()
        {
            List<Employee> employee = new List<Employee>();
            Employee emp;
            int count = 0;

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Vishal Kumar";
            emp.DOB =Convert.ToDateTime("15-03-2001");
            emp.MobileNo ="8294628952";
            emp.EmailId ="kumar.vishal@thinksys.com";
            emp.Salary =20000.00;
            emp.DOJ= Convert.ToDateTime("13-09-2022");
            employee.Add(emp);

            emp = new Employee(); 
            emp.EmpID = ++count;
            emp.Name = "Shree Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1998");
            emp.MobileNo = "8294645672";
            emp.EmailId = "kumar.Shree@thinksys.com";
            emp.Salary =34985.5;
            emp.DOJ = Convert.ToDateTime("18-10-2012");
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Manish Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1998");
            emp.MobileNo = "8245678954";
            emp.EmailId = "kumar.Manish@thinksys.com";
            emp.Salary =12706;
            emp.DOJ = Convert.ToDateTime("15-11-2020");
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Neha Kumari";
            emp.DOB = Convert.ToDateTime("10-05-1991");
            emp.MobileNo = "8865444355";
            emp.EmailId = "kumari.Neha@thinksys.com";
            emp.Salary =19505;
            emp.DOJ = Convert.ToDateTime("28-09-2018");
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Rajiv Kumar";
            emp.DOB = Convert.ToDateTime("10-05-2002");
            emp.MobileNo = "6267339867";
            emp.EmailId = "kumar.Rajiv@thinksys.com";
            emp.Salary =162002;
            emp.DOJ = Convert.ToDateTime("23-12-2019");
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Rohan Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1989");
            emp.MobileNo = "8837658684";
            emp.EmailId = "kumar.Rohan@thinksys.com";
            emp.Salary =173003;
            emp.DOJ = Convert.ToDateTime("07-02-2013");
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Manoj Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1994");
            emp.MobileNo = "987078909";
            emp.EmailId = "kumar.Manoj@thinksys.com";
            emp.Salary =29898;
            emp.DOJ = Convert.ToDateTime("09-09-2021");
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Mohit Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1991");
            emp.MobileNo = "8978779079";
            emp.EmailId = "kumar.Mohit@thinksys.com";
            emp.Salary =12098;
            emp.DOJ = Convert.ToDateTime("12-05-2022");
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Hari Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1995");
            emp.MobileNo = "879086587";
            emp.EmailId = "kumar.Hari@thinksys.com";
            emp.Salary =67585;
            emp.DOJ = Convert.ToDateTime("17-09-2021");
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Manisha Kumari";
            emp.DOB = Convert.ToDateTime("10-05-1997");
            emp.MobileNo = "9089086567";
            emp.EmailId = "kumari.Manisha@thinksys.com";
            emp.Salary =42383;
            emp.DOJ = Convert.ToDateTime("19-05-2022");
            employee.Add(emp);

            return employee;

        }
    }
}
