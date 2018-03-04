// Write a program that prints a triangle given an integer input from the user
// if input is 5:
//5
//55
//555
//5555
//55555            

Console.WriteLine("Type in a number: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
  for (j= 0; j < i; j++)
  {
    Console.Write(i);                
  }            
  Console.Write("\n");
}