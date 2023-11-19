using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime JoinedDate { get; set; }
        public required decimal Salary { get; set; }
        public Department? Department { get; set; }
    }

}
