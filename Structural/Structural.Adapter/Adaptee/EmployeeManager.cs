using System.Collections.Generic;
using System.Text;

namespace Structural.Adapter.Adaptee
{
    public class EmployeeManager
    {
        public EmployeeManager()
        {
            this.DepartmentName = "Research and Development";
            this.Employees = new List<Employee>
            {
                new Employee("Reza" , "Puoya"),
                new Employee("Ali"  , "Alawi"),
                new Employee("Hassan" , "Hassani")
            };
        }


        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }

        public virtual string GetAllEmployees()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine($"List of Employees of Department of {DepartmentName} :");
            message.AppendLine("-----------------------------------------------------------");
            message.AppendLine("Id\t\t\t - First Name \t - Last Name ");
            message.AppendLine("-----------------------------------------------------------");

            foreach (var employee in this.Employees)
            {
                message.AppendLine($"{employee.Id} \t\t - {employee.Fname} \t\t - {employee.Lname}");
            }
            return message.ToString();
        }
    }
}