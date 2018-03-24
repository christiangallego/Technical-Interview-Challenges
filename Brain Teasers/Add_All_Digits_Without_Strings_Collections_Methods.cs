using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine(Sum(85));
  }
  
  static public int Sum(int number)
{
  var sum = 0;
  while (number != 0) 
  {     
  sum = sum + number % 10;
  number = number / 10; 
  }
  return sum;
}