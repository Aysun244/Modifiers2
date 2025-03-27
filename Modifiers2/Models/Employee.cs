using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public string Name { get; set; }
        public bool IsSuccessfull { get; set; }
        public int Salary { get; set; }

        public Employee(string name, bool isSuccesfull, int salary)
        {
            Name = name;
            IsSuccessfull = isSuccesfull;
            Salary = salary;

        }

    }
}
