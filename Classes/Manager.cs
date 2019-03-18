using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Manager:Employee
    {
        private double Bonus { get; set; }
        public Manager(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmpRole = role;
            Salary = salary;
        }
        public Manager()
        {

        }
        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
       
    }
    public enum Role
    {
        Sales = 1,
        Manager,
        Other
    }
}
