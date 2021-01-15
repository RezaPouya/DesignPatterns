using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite.Component
{
    public interface IEmployee
    {
        string Detail { get; set; }
        void GetDetails();
    }
}
