using System;

namespace Classes
{
    public class Employee
    {

        // Some readonly properties (let's talk about gets, baby)
        public string? FirstName { get; set; }  //the ? means the property can be null

        public string? LastName { get; set; }

        public string? Title { get; set; }

        public DateTime  StartDate { get; set;}
        

}
  
  

    }

// Create an Employee.cs file and then define a class for Employee. An employee has the following properties.
// First name (string)
// Last name (string)
// Title (string)
// Start date (DateTime)