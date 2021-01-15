using System;
using System.Collections.Generic;

namespace Creational.Prototype
{
    public class Person : ICloneable
    {
        public Person()
        {
        }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public List<Job> Expriences { get; set; }

        public object ShallowClone(bool deepCopy = false)
        {
            if (deepCopy == false)
                return this.MemberwiseClone();

            return Clone();
        }

        public object Clone()
        {
            var exprincesList = new List<Job>();
            foreach (var job in this.Expriences)
            {
                var tmp = new Job
                {
                    Order = job.Order,
                    Company = job.Company,
                    Role = job.Role
                };
                exprincesList.Add(tmp);
            }

            return new Person()
            {
                Fname = this.Fname,
                Lname = this.Lname,
                Expriences = exprincesList
            };
        }
    }

    public class Job
    {
        public int Order { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
    }
}