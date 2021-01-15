using Structural.Composite.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite.Leaf
{
    public class Employee : IEmployee
    {
        public Employee(string fname, string lname, string department)
        {
            Fname = fname;
            Lname = lname;
            Department = department;
        }

        public string Detail { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Department { get; set; }

        public void GetDetails()
        {
            Detail = $" {Fname} {Lname} --- Department: {Department}";
        }
    }
}
