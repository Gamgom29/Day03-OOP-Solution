using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Builtin_Interfaces
{
    class EmployeeIDComparer : IComparer
    {
        public int Compare(object? X, object? Y)
        {
            Employee? employeeX = (Employee?)X;
            Employee? employeeY = (Employee?)Y;

            return employeeX?.Id.CompareTo(employeeY?.Id) ?? (employeeY is null ? 0 : -1);
        }
    }
}
