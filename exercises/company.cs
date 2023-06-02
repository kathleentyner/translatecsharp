using System;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        // Setting the value of Employees in the constructor as a new List<Employee> (News Flash: Declaring a property gives it an initial vlaue of null). This will allow you to add newly created employees to the Employees list in the final step below.  
        public List<Employee> EmployeeList { get; set; } // Create a public property for holding a list of current employees. Declared property
        //company constructor
        public Company(string name, DateTime createdOn)
        {
            EmployeeList = new List<Employee>(); //allows user to add stuff to list. Initialized property
            Name = name;
            CreatedOn = createdOn;
        }




        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
    }
}
