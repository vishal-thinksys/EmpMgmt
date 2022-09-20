using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt.Entity
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }       
        public DateTime DOB { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
    }
}
