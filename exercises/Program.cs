using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = "Gatewood Inc."; 
            DateTime cDate = new DateTime(2009, 09, 01);


            // Create an instance of a company. Name it whatever you like.
            Company company = new Company (companyName, cDate); 
          

            // Create three employees

            Employee cat = new Employee ();
            cat.FirstName = "Dilly"; 
            cat.LastName = "Cat";
            cat.Title = "Lord of the Manor";
            cat.StartDate = new DateTime(2009, 11, 01); 

            Employee rabbit = new Employee (); 
            rabbit.FirstName = "Bonnie";
            rabbit.LastName = "Bonita"; 
            rabbit.Title = "Velvet Queen";
            rabbit.StartDate = new DateTime(2022, 07, 01); 

            Employee dog = new Employee (); 
            dog.FirstName = "Birdie"; 
            dog.LastName ="Bird";
            dog.Title = "Swamp Queen"; 
            dog.StartDate = new DateTime(2019, 09, 01);

            // Assign the employees to the company
        company.EmployeeList.Add(cat);
        company.EmployeeList.Add(rabbit);
        company.EmployeeList.Add(dog);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            company.EmployeeList.ForEach(emp => Console.WriteLine($"{emp.FirstName} {emp.LastName} works for {company.Name} as a {emp.Title} since {emp.StartDate}."));
        }
    }
}

// The Company class should also have a ListEmployees() method which writes a string to the console about each employee, such as "Jane Doe works for Acme, Inc. as Lion Tamer since 3/23/15."
// In the Main method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.