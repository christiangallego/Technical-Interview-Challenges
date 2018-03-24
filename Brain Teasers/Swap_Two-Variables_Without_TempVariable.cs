using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    
  int a = 656;
  int b = 4;
   
    b = b - a; // -652
    a = a + b; // 4
    b = a - b; // 656
    
    Console.WriteLine(a);
    Console.WriteLine(b);

  }
}