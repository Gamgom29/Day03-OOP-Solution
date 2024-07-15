using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.IColneable_Interface
{
    class Employee : ICloneable
    {
        public int Id { get; set; }
        public string?  Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }

        public Employee()
        {
            
        }

        // Copy Constructor is a Special Constructor is used to make a Deep Copy
        public Employee(Employee employeeCopy)
        {
            this.Id = employeeCopy.Id;
            this.Name = employeeCopy.Name;
            this.Salary = employeeCopy.Salary;
            this.Department = (Department?)employeeCopy?.Department?.Clone();
        }
        public object Clone()
        {
            return new Employee(this);

            ///return new Employee()
            ///{
            ///    Id = this.Id,
            ///    //Name = (string?) this?.Name?.Clone(),
            ///    Name = this.Name,
            ///    Salary = this.Salary,
            ///    Department = (Department?) this?.Department?.Clone()
            ///};
        }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Salary: {Salary}";
        }
    }
}
