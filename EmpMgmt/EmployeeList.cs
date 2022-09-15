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
            employee.Add(emp);

            emp = new Employee(); 
            emp.EmpID = ++count;
            emp.Name = "Shree Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1998");
            emp.MobileNo = "8294645672";
            emp.EmailId = "kumar.Shree@thinksys.com";
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Manish Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1998");
            emp.MobileNo = "8245678954";
            emp.EmailId = "kumar.Manish@thinksys.com";
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Neha Kumari";
            emp.DOB = Convert.ToDateTime("10-05-1991");
            emp.MobileNo = "8865444355";
            emp.EmailId = "kumari.Neha@thinksys.com";
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Rajiv Kumar";
            emp.DOB = Convert.ToDateTime("10-05-2002");
            emp.MobileNo = "6267339867";
            emp.EmailId = "kumar.Rajiv@thinksys.com";
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Rohan Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1989");
            emp.MobileNo = "8837658684";
            emp.EmailId = "kumar.Rohan@thinksys.com";
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Manoj Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1994");
            emp.MobileNo = "987078909";
            emp.EmailId = "kumar.Manoj@thinksys.com";
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Mohit Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1991");
            emp.MobileNo = "8978779079";
            emp.EmailId = "kumar.Mohit@thinksys.com";
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Hari Kumar";
            emp.DOB = Convert.ToDateTime("10-05-1995");
            emp.MobileNo = "879086587";
            emp.EmailId = "kumar.Hari@thinksys.com";
            employee.Add(emp);

            emp = new Employee();
            emp.EmpID = ++count;
            emp.Name = "Manisha Kumari";
            emp.DOB = Convert.ToDateTime("10-05-1997");
            emp.MobileNo = "9089086567";
            emp.EmailId = "kumari.Manisha@thinksys.com";
            employee.Add(emp);

            return employee;

        }
    }
}
