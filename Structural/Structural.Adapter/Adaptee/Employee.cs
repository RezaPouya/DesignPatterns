using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Adapter.Adaptee
{
    public class Employee
    {
        public Employee(string fname, string lname)
        {
            this.Id = $"{nameof(Employee)}-{Guid.NewGuid().GetHashCode().ToString("x")}";
            Fname = fname;
            Lname = lname;
        }

        public Employee(string id, string fname, string lname)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
        }

        public string Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
