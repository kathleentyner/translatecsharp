
/*
//Restriction/Filtering Operations

// Find the words in the collection that start with the letter 'L'
List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

IEnumerable<string> LFruits = from fruit in fruits  
where fruit.StartsWith("L")
select fruit;
        
       
        // Display fruit that starts with L
        foreach (string fruit in LFruits)
        {
            Console.WriteLine(fruit);
        }

// Which of the following numbers are multiples of 4 or 6
List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0  || 6 == 0);
fourSixMultiples.ToList().ForEach(number => Console.WriteLine(number + " is divisable by 4 or 6"));

//Ordering Operations

//// Order these student names alphabetically, in descending order (Z to A)
List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

List<string> descend = new List<string>(names.OrderByDescending(n => n));
    foreach (string name in descend)
   {     Console.WriteLine(name);
}

// Build a collection of these numbers sorted in ascending order
List<int> allnumbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

List<int> ascending = new List<int>(allnumbers.OrderBy(n=>n)); 
foreach(int number in ascending)
{
Console.WriteLine(number);}


//Aggregate Operations
// Output how many numbers are in this list
List<int> examplenumbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

    var countnumbers = examplenumbers.Count(); //alternative to foreach
{
    Console.WriteLine(countnumbers);
}

// How much money have we made?
List<double> purchases = new List<double>()//double means a decimle?
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};

var total = purchases.Sum();

    Console.WriteLine(total);

// What is our most expensive product?
List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};

var mostexpensive = prices.Max();

    Console.WriteLine(mostexpensive);*/




//Partitioning Operations
// List<int> wheresSquaredo = new List<int>()
// {
//     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
// };
// List<int> nonSquares = wheresSquaredo.TakeWhile(number => Math.Sqrt(number) % 1 != 0).ToList();
//             foreach (var sqnum in nonSquares)
//             {
//                 Console.WriteLine(sqnum.ToString());
//             }
/*
    Store each number in the following List until a perfect square
    is detected.

    Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/


//Using Custom Types
// Build a collection of customers who are millionaires
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };
       var millionaires = customers.Where(customer => customer.Balance >= 1000000) //find the customers where the balance is >= t 1000000
        .GroupBy(customer => customer.Bank)//group by the banks. Use the key of bank
        .Select(group => new { Bank = group.Key, Count = group.Count() }); //count the number of banks per group. 
;
        foreach (var millionaire in millionaires)//what are we wanting to console? the millionaires! 
        {
            Console.WriteLine($"{millionaire.Bank} {millionaire.Count}");//list the bank and the # of millionaires
        }
    }
}
  
/*
    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1
*/