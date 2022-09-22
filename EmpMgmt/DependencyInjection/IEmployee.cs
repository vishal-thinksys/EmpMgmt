using EmpMgmt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt.DependencyInjection
{
    public interface IEmployee
    {
        List<Employee> ListOfAllEmployee();
    }
}
