using System;

class Temp
{
  static void Main()
  {
    Console.WriteLine("Enter the current temperature (in Fahrenheit): ");
    int inputTemp = int.Parse(Console.ReadLine());
    if (inputTemp > 90)
    {
      Console.WriteLine("Good luck! It's hot as balls out there!");
    } else if(inputTemp > 80)
    {
      Console.WriteLine("I'd recommend wearing shorts and a T-shirt today.");
    } else if (inputTemp > 65)
    {
      Console.WriteLine("The temperature is perfect! Wear what you like best.");
    } else if (inputTemp > 50)
    {
      Console.WriteLine("It's a little chilly. Probably need a light jacket.");
    } else if (inputTemp > 32)
    {
      Console.WriteLine("Better bundle up! It's cold out there!");
    } else
    {
      Console.WriteLine("Oh man! You are screwed!! It's freezing out there!!");
    }
  }
}