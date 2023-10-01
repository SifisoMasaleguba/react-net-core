using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEmployment.Models
{
    public class Employee
    {
        public int Employee_ID { get; set; }
        public string EmployeeName { get; set; }
        public int Department_ID { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
