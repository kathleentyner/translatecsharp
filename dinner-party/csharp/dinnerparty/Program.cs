﻿using System;

using System.Collections.Generic;

using System.Linq;

namespace DinnerParty
{
    class Program
    {
        static void Main()
        {
            //Create the individual Guests - built the object in the Guest.cs file
            List<Guest> Guests = new List<Guest>()
          {
                new Guest {Name = "Marilyn Monroe", Occupation = "entertainer", Bio = "(1926 - 1962) American actress, singer, model"},
                new Guest {Name = "Abraham Lincoln", Occupation = "politician", Bio = "(1809 - 1865) US President during American civil war"},
                new Guest {Name = "Martin Luther King", Occupation = "activist", Bio = "(1929 - 1968)  American civil rights campaigner"},
                new Guest {Name = "Rosa Parks", Occupation = "activist", Bio = "(1913 - 2005)  American civil rights activist"},
                new Guest {Name = "Peter Sellers", Occupation = "entertainer", Bio = "(1925 - 1980) British actor and comedian"},
                new Guest {Name = "Alan Turing", Occupation = "computer scientist", Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"},
                new Guest {Name = "Admiral Grace Hopper", Occupation = "computer scientist", Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"},
                new Guest {Name = "Indira Gandhi", Occupation = "politician", Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"}
          };

            //Create the tables the guests will be assigned too. 
            List<Guest> Table1 = new List<Guest>();
            List<Guest> Table2 = new List<Guest>();
            List<string> occupations = new List<String>();
            foreach (Guest guest in guests)
            {
         
                if (occupations.Contains(guest.occupation)) //look at the guest occuppation; if there is already a guest with that occupation
                {
                    Table2.Add(guest); //add the guest to table 2 - add is like push in javascript
                }
                else
                {
                    Table1.Add(guest);
                    occupations.Add(guest.Occupation); //if there isn't a guest with that occupation, add to table 1.
                }
            }


            Console.WriteLine("Table One");
            Console.WriteLine();
            foreach (Guest guest in Table1) //look at guests in table1 
            {
                Console.WriteLine($"{guest.Name}: {guest.Occupation}; {guest.Bio}");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Table Two");
            Console.WriteLine();
            foreach (Guest guest in Table2) // look at guests in table2
            {
                Console.WriteLine($"{guest.Name}: {guest.Occupation}; {guest.Bio}");
            }
        }
    }
}