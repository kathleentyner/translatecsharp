using System; 

  for(int n=1; n<=100; n++) { //change let to int - it needs to define that it's an integer.
    if (n % 15 == 0) { //if the integer is divisible (%) by 15
      Console.WriteLine("fizzbuzz");
    } else if (n % 3 == 0) {
      Console.WriteLine("fizz");
    } else if (n % 5 == 0) {
      Console.WriteLine("buzz");
    } else {
      Console.WriteLine(n); //if it doesnt meet the 3 defined conditions
    }
  }


