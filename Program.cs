using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees

        public static List<Employee> EmployeeList = new List<Employee>();

        // Create a method that allows external code to add an employee
        public static void AddEmployee(Employee emp){
            EmployeeList.Add(emp);
        }
        // Create a method that allows external code to remove an employee
        public static void RemoveEmployee(Employee emp){
            EmployeeList.Remove(emp);
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */

        public Company(string name){
            this.Name = name;
            this.CreatedOn = new DateTime();
        }
    }
    
    public class Employee{

        public string name;
        public string jobTitle;
        public string startDate;

         /*
         Methods
          */
          public Employee(string Name, string Job, string Date){
              this.name = Name;
              this.jobTitle = Job;
              this.startDate = Date;
          }
    }

    public class Program{

        public static void Main(){

            new Company("NSS");

            Company.EmployeeList.Add(new Employee("Chaz", "Developer", "Sept 22"));
            Company.EmployeeList.Add(new Employee("Matt", "Cool Guy", "Sept 21"));
            Company.EmployeeList.Add(new Employee("Steve", "Does Stuff", "Sept 20"));

            // List<Employee> EmployeeList = new List<Employee>(){
            // new Employee("Chaz", "Developer", "Sept 22"),
            // new Employee("Tiny Rick", "Scientist", "Sept 21"),
            // new Employee("Steve", "Janitor", "Sept 23")
        // };


            foreach(Employee e in Company.EmployeeList){
                Console.WriteLine($"{e.name} {e.jobTitle} {e.startDate}");
            }

        }
    }
}
