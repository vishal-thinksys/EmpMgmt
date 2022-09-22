using EmpMgmt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt.DependencyInjection
{
    public class EmployeeBAL
    {
        private readonly IEmployee _IEmployee;

        public EmployeeBAL(IEmployee employee)
        {
            this._IEmployee = employee;
        }
        public List<Employee> ListOfAllEmployee()
        {
            return _IEmployee.ListOfAllEmployee();
        }
    }
}
