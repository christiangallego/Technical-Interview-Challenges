// Given an integer num, repeatedly add all its digits until the result has only one digit.

// For example:

// Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.

// Sum(7)
// Sum(38)
// Sum(381)

static public void Sum(int number)
{
  while (number >= 10)
  {                           
  int rightNum = number % 10; 
  int leftNum = number / 10;  
  number = rightNum + leftNum; 
  if (number < 10)
    break;
}
  return number;

// with recursion

// if (number >= 10)
// {
//   int rightNum = number % 10;
//   int leftNum = number / 10;
//   number = rightNum + leftNum;
//   Sum(number);
// }
// else if (number < 10) 
//   Console.WriteLine(number);

