using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Manager
    {
        protected Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            return employee;
            
        }     
    }
}

