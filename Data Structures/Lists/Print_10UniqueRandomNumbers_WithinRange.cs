using System;
using System.Collections.Generic;

class MainClass
{
  public static void Main (string[] args)
  {
    Random random = new Random();
    List<int> nums = new List<int>();
   
    while(nums.Count < 10) 
    {
      int answer = random.Next(0, 30);
      if(!nums.Contains(answer)) 
      {
        nums.Add(answer);
      }
    }
    
    foreach(int number in nums)
    {
      Console.WriteLine(number);
    }
  }
}
