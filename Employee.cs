/*
Display the Employee details using collections. 
A console application to print the employee details using collections. 
using a dictionary 
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemoConApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }

        public Employee() { }

        public Employee(int eId, string eName, int eAge, double eSalary, string eGender) {
            this.Id = eId;
            this.Name = eName;
            this.Age = eAge;
            this.Salary = eSalary;
            this.Gender = eGender;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionDemoConApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var employeeDict = new Dictionary<int, Employee>()
            {
                { 1, new Employee { Id=111, Name="Joe Howard", Age=34, Salary=67000.00, Gender="Male" }},
                { 2, new Employee { Id=222, Name="Sam Jones", Age=25, Salary=64500.00, Gender="Male" }},
                { 3, new Employee { Id=333, Name="Stan Lee", Age=40, Salary=62300.00, Gender="Male" }},
                { 4, new Employee { Id=444, Name="Lucy Baldwin", Age=22, Salary=69500.00, Gender="Female" }},
                { 5, new Employee { Id=555, Name="Carol Burns", Age=30, Salary=69500.00, Gender="Female" }}
            };




            foreach (var index in Enumerable.Range(1, 5))
            {
                Console.WriteLine($"{employeeDict[index].Id} \t" +
                    $"{employeeDict[index].Name} \t" +
                    $"{employeeDict[index].Age} \t" +
                    $"{employeeDict[index].Salary} \t" +
                    $"{employeeDict[index].Gender}");
            }
        }
    }
}
