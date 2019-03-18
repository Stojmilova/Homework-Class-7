using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1,2 and 3:
            Console.WriteLine("----------------------------------------------------------");
            Manager managerPerson = new Manager("William", "Damian", Manager.Role.Manager, 3500);
            managerPerson.AddBonus(500);
            managerPerson.GetSalary();
            managerPerson.PrintInfo();
            Console.WriteLine($"The manager:{managerPerson.FirstName}, has salary: {managerPerson.GetSalary()}$");

            Console.WriteLine("----------------------------------------------------------");
            SalesPerson salePerson = new SalesPerson("Jack", "Connor");
            salePerson.SetAddSuccessRevenue(2500);
            salePerson.GetSalary();
            salePerson.PrintInfo();
            Console.WriteLine($"Sale Person: {salePerson.FirstName}, has salary: {salePerson.GetSalary()}$ ");

            Console.WriteLine("----------------------------------------------------------");
            Employee employeePerson = new Employee();
            employeePerson.FirstName = "James";
            employeePerson.LastName = "Reece";
            employeePerson.EmpRole = Employee.Role.Other;   
            employeePerson.SalaryEmp(400);
            employeePerson.PrintInfo();
            Console.WriteLine($"Other employee: {employeePerson.FirstName},has salary: {employeePerson.SalaryEmp(400)}$");
          

            Console.ReadLine();

        }
    }
}
