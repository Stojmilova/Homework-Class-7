using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     public class SalesPerson:Employee
     {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string first, string last)
        {
            FirstName = first;
            LastName = last;
            Salary = 500;
            EmpRole = Role.Sales;

        }
        public void SetAddSuccessRevenue(int value)
        {

            SuccessSaleRevenue = value;

        }
        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            
            {
                return Salary + 1000;
            }
            if (SuccessSaleRevenue > 5000)
            {
                return Salary + 1500;
            }
            else
            {
                return Salary;
            }


        }
    }
}
