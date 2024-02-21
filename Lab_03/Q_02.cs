using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    public class Employee
    {
        private int EmployeeId;
        private string FullName;
        private double salary;

        public Employee(int EmployeeId , string FullName, double salary) //constructor
        {
            this.EmployeeId = EmployeeId;
            this.FullName = FullName;
            this.salary = salary;
        }
        public int ID => EmployeeId; //read only property(get)

        public string fullName //read write property
        {
            get => FullName;
            set => FullName = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee Id : {EmployeeId}");
            Console.WriteLine($"Employee Name : {FullName}");
            Console.WriteLine($"Salary : {salary} \n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101 , "John Doe" , 50000);

            Console.WriteLine("Employee Information \n ");
            employee.DisplayEmployeeInfo();

            Console.WriteLine($"Employee Id : {employee.ID}");

            employee.fullName = "Udani Kodithuwakku";
            Console.WriteLine($"Update full name : {employee.fullName}");

            employee.Salary = 22000;
            Console.WriteLine($"Update salary : {employee.Salary}");

            Console.ReadLine();

        }
    }
}
