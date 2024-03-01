using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD11
{
    /*public class Employee
    {
        public int index { get; set; }
        public string EmployeeNo {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public string Dpartment;
        public int DepartmentId { get; set; }

        public override string ToString()
        {
            return $"" + $"{index.ToString().PadLeft(3 , '0')}\t"
                   + $"{EmployeeNo.PadRight(13, ' ')}\t" +
                   $"{Name.PadRight(20, ' ')}\t" +
                   $"{Email.PadRight(32, ' ')}\t" +
                   $"{Salary}\t" +
                   $"[{string.Join(" , ", Skills)}]";

        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj.GetType().Equals(this.GetType())))
            {
                return false;
            }
            Employee e = (Employee)obj;
            return e.Email.Equals(this.Email);
        }

        public override int GetHashCode()
        {
            return this.Email.GetHashCode() + 7 * 13;
        }

    }*/

    public class Employee
    {
        public Employee() { }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public string Gender { get; set; }

        public int DepartmentId { get; set; }

        public bool HasHealthInsurance { get; set; }

        public bool HasPensionPlan { get; set; }

        public decimal Salary { get; set; }

        public string FullName => $"{FirstName} {LastName}";


    }
}
