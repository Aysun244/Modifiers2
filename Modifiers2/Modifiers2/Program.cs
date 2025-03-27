using Models;

namespace Modifiers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Suyud",false, 7699);
            Employee employee2 = new Employee("Xanbala", true, 600);
            Assistant assistant = new Assistant();
            assistant.GetFeedBack(employee1);
            assistant.GetFeedBack(employee2);
           
        }
    }
}
