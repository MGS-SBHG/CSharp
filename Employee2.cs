/*
WAP to create a class Employee with properties 
Name, Designation, Salary and JoinDate.
*/

List All Employees 
	Add new Employee  
	Update Employee 
	Remove Employee

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    public class Employee2
    {
        // properties Name, Designation, Salary and JoinDate.
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public string JoinDate { get; set; }

        public Employee() { }

        public Employee(string eName, string eDesignation, double eSalary, string eJoinDate)
        { 
            this.Name = eName;
            this.Designation = eDesignation;
            this.Salary = eSalary;
            this.JoinDate = eJoinDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeDict = new Dictionary<int, Employee>()
            {
                // Add new Employees
                { 1, new Employee { Name="Joe Howard", Designation="Developer", Salary=55000.00, JoinDate="Jan 02 2013" }},
                { 2, new Employee { Name="Sam Jones", Designation="UI Developer", Salary=64500.00, JoinDate="Jan 02 2014" }},
                { 3, new Employee { Name="Stan Lee", Designation="DB Admin", Salary=62300.00, JoinDate="Feb 05 2013" }},
                { 4, new Employee { Name="Lucy Baldwin", Designation="Scrum Master", Salary=69500.00, JoinDate="Sep 02 2018" }},
                { 5, new Employee { Name="Carol Burns", Designation="Project Mgr", Salary=72500.00, JoinDate="Jan 02 2010" }},
            };

            // Add new Employee
            employeeDict.Add(6, new Employee { Name = "Karen Russell", Designation = "C# Developer", Salary = 55000.00, JoinDate = "Jan 02 2019" });
            employeeDict.Add(7, new Employee { Name = "Ravi Patel", Designation = "Java Developer", Salary = 55000.00, JoinDate = "Jan 10 2018" });

            // Update Employee Lucy Baldwin gets a new salary
            employeeDict[4].Salary=75000.00;

            // Remove Employee nbr 2 "Sam Jones" resigned
            employeeDict.Remove(2);

            // print employees
            foreach (var index in Enumerable.Range(1, 7))
                try
                {
                    Console.WriteLine(
                        $"{employeeDict[index].Name} \t" +
                        $"{employeeDict[index].Designation} \t" +
                        $"{employeeDict[index].Salary} \t" +
                        $"{employeeDict[index].JoinDate}");
                }
                catch {
                    Console.WriteLine("Employee {0} No Longer With The Company!", index);
                }

        }
    }
}

