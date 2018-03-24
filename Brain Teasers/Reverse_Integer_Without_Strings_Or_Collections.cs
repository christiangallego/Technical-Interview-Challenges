using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine(Reverse(1234));
  }
  
  public static int Reverse(int number)
  {
    int reversedNum = 0;
    while(number != 0) 
    {
      // gets right most number
      int remainderDigit = number % 10; 
      // adds right most number to variable in reverse order
      reversedNum = (reverseNum * 10) + remainderDigit; 
      // takes off right most number
      number = number / 10;  
    }
    return reverse;
  }
}