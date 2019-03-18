using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role EmpRole { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {

        }

        public void PrintInfo()
        {
            
          Console.WriteLine("First Name: {0}, Last Name: {1}, Salary: {2}$", FirstName, LastName, Salary);
        }


        public double SalaryEmp(double value)
        {
            return Salary = value;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public enum Role
        {
            Sales = 1, 
            Manager,
            Other
        }
    }
}
