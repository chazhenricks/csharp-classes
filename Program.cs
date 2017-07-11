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
        public void AddEmployee(Employee emp){
            EmployeeList.Add(emp);
        }
        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(Employee emp){
            EmployeeList.Remove(emp);
        }

        public void ListEmployees(){
            foreach(Employee e in Company.EmployeeList){
                Console.WriteLine($"{e.name} {e.jobTitle} {e.startDate}");
            }
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */

        public Company(string name){
            this.Name = name;
            this.CreatedOn = DateTime.Now;
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

            Company ChazCOM = new Company("CHAZCOM");

            Employee chaz = new Employee("Chaz", "Developer", "Sept 22");
            Employee matt = new Employee("Matt", "Cool Guy", "Sept 21");
            Employee steve = new Employee("Steve", "Does Stuff", "Sept 20");

            ChazCOM.AddEmployee(chaz);
            ChazCOM.AddEmployee(steve);
            ChazCOM.AddEmployee(matt);
           

            ChazCOM.ListEmployees();
            ChazCOM.RemoveEmployee(matt);
            ChazCOM.ListEmployees();

            Console.WriteLine($"{ChazCOM.Name} {ChazCOM.CreatedOn}");
        }
    }
}
