using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Assistant : Manager
    {

        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                employee = GetPromotion(employee);
                Console.WriteLine($"Ugurlu sexs:{employee.Name};Yeni maas:{employee.Salary}");
            }
            else
            {
                Console.WriteLine("Qeyd olunan sexs ugursuz iscidir");
            }
        }
    }

}
