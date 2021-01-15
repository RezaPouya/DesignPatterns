using Structural.Composite.Component;
using Structural.Composite.Leaf;
using System.Collections.Generic;

namespace Structural.Composite.Composite
{
    public class Manager : IEmployee
    {
        public Manager(string fname, string lname, string department)
        {
            Fname = fname;
            Lname = lname;
            Department = department;
            Subordinates = new List<IEmployee>
            {
                new Employee("Hassan" , "Hassani" , department),
                new Employee("Ali"    , "Alawi" , department),
                new Employee("Mehran" , "Mehrani" , department),
            };
        }

        public Manager(string fname, string lname, string department, List<IEmployee> subordinates)
        {
            Fname = fname;
            Lname = lname;
            Department = department;
            Subordinates = subordinates;
        }

        private List<IEmployee> Subordinates { get; set; }
        public string Detail { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Department { get; set; }

        public void GetDetails()
        {
            Detail = $" {Fname} {Lname} --- Department: {Department}";
            Detail += "\n";
            Detail += "-----------------------------------------------\n";
            foreach (var employee in Subordinates)
            {
                employee.GetDetails();
                Detail += "\n" + employee.Detail;
            }
        }
    }
}