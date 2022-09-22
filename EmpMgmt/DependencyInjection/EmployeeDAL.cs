using EmpMgmt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt.DependencyInjection
{
    public class EmployeeDAL : IEmployee
    {
        public List<Employee> ListOfAllEmployee()
        {
            EmployeeList list=new EmployeeList();
            return list.All_Employee();
        }
    }
}
