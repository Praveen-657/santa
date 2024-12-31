using System;
public class Quiz
{
 public static void Main(string [] args)
 {
    int count=0;
    Console.WriteLine("enter your name:");
    string name=Console.ReadLine();
    Console.WriteLine($"Hello {name}, Welcome to Santa Quiz \n");
    Console.WriteLine("What is the largest planet in our solar system? ");
    string solar=Console.ReadLine();
    string lower1=solar.ToLower();
    if(lower1=="jupiter")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("How many continents are there?");
    string continents=Console.ReadLine();
    string lower2=continents.ToLower();
    if(lower2=="seven")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine( "What is the currency of the United States?");
    string currency=Console.ReadLine();
    string lower3=currency.ToLower();
    if(lower3=="dollar")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("What is the tallest animal in the world?");
    string world=Console.ReadLine();
    string lower4=world.ToLower();
    if(lower4=="giraffe")
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine("Who was the first man to walk on the moon?");
    string moon=Console.ReadLine();
    string lower5=moon.ToLower();
    if(lower5=="purple")  
    {
    count++;
    Console.WriteLine("Correct! You've earned a gift.");
    }
    else
    {
    Console.WriteLine("Oops! That's not correct.");
    }
    Console.WriteLine($"santa Quiz is completed \n Congratulations you answered {count} questions correctly.So,You earned {count} gift(s) from santa");
 }
}

