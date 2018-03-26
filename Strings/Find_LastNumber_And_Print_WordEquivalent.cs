using System;

class MainClass 
{
  public static void Main (string[] args)
  {
      Console.WriteLine(LastNum(35));
  }

  public static string LastNum (int num) 
  {
    int number = num % 10;
    string answer = "";
    
    switch(number)
    {
      case 0:
        answer = "zero";
        break;
      case 1:
        answer = "one";
        break;
      case 2:
        answer = "two";
        break;
      case 3:
        answer = "three";
        break;
      case 4:
        answer = "four";
        break;
      case 5:
        answer = "five";
        break;
      case 6:
        answer = "six";
        break;
      case 7:
        answer = "seven";
        break;
      case 8:
        answer = "eight";
        break;
      case 9:
        answer = "nine";
        break;
    }
    return answer;
  } 

// Solution using Dictionary Collection
/* 
  Dictionary<int, string> d = new Dictionary<int, string>()
  {   
    {1, "one"},
    {2, "two"},
    {3, "three"},
    {4, "four"},
    {5, "five"}
  };

  if (d.ContainsKey(num))
      {
      Console.WriteLine(d[num]);
      }                       

  // Loop through Dictionary
  foreach (var pair in d)
      {
      Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
      }
*/
}