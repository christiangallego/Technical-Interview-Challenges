using System;

class MainClass 
{
  public static void Main (string[] args)
  {
      Console.WriteLine(LeapYear("1987"));
  }

  public static string LeapYear (string year) 
  {
    int result;
    string answer = "";
    int.TryParse(year, out result);
    
    if (result % 4 == 0)
      {
        answer = string.Format("{0} is a leap year!", result);
      }
    else
      {
        answer = string.Format("{0} is not a leap year!", result);
      }
    return answer;
  }

}