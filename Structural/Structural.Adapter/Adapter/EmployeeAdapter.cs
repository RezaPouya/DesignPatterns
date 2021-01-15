using Structural.Adapter.Adaptee;
using Structural.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Structural.Adapter.Adapter
{
    public class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            var result = new List<Object>();

            foreach(var item in this.Employees)
            {
                result.Add(new { 
                    Department = this.DepartmentName, 
                    item.Id, 
                    item.Fname, 
                    item.Lname });
            }

            var returnJson = 
                JsonSerializer.Serialize(result
                    , new JsonSerializerOptions() { 
                            WriteIndented = true 
                } );

            return returnJson;
        }
    }
}
