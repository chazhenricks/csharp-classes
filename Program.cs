using System;
using System.Collections.Generic;

namespace classes
{
  public class Company
    {
        /*
            Some readonly properties
        */
            //these are private fields that hold the name, jobTitle and startDate of an employee. 
            private string name;
            private string jobTitle;
            private string startDate;
  
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<string> employeeList = new List<string>();

        // Create a method that allows external code to add an employee

        public void addEmplyee(string employee){
            employeeList.Add(employee);
        }

        // Create a method that allows external code to remove an employee

        public void removeEmployee(string employee){
            employeeList.Remove(employee);
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
            public void Employee(string employeeName){
            name = employeeName;
        }
    }
}
