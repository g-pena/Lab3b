using System;

class Program {
  public static void Main (string[] args) {
    //variables
    double sales;
    string name;
    double commission;

    //Salesperson's name
   
    Console.WriteLine ("Enter salesperson's name:"); 
    name = Console.ReadLine();

    //Sales amount
    Console.WriteLine("Enter sales amount:");
    sales = Convert.ToDouble(Console.ReadLine());

    //Calculate commission 200 + (0.09 * SALESAMOUNT)

    commission = 200+(0.09*sales);
    Console.WriteLine("Sales commission for "+ name+" is $" + commission+ ".");
   

    //Display preformance status

  /* a) $0–2999 - Poor
      c) $3000–4999 - Average
      d) $5000–9999 - Good
      e) $10000–14999 - Excellent
      f) $15000 and above – Outstanding */

    if (sales >= 0 && sales <= 2999)
    {
      Console.WriteLine("Performance is poor.");
    }
    else if (sales >= 3000 && sales <= 4999)
    {
      Console.WriteLine("Performance is average.");
    }
    else if (sales >= 5000 && sales <= 9999)
    {
      Console.WriteLine("Performance is good.");
    }
    else if (sales >= 10000 && sales <= 14999)
    {
      Console.WriteLine("Performance is excellent.");
    }
    else
    {
      Console.WriteLine("Performance is outstanding.");
    }








  }
}