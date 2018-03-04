// Write a program that will count the words in a string 
// The first word will be lowercase and the first letter of every following word will be uppercase     
// thisIsAnExample 
  
Console.WriteLine("Type your input here");
string input = Console.ReadLine();
int count = 1; // initialize to 1 because the first word will always be lowercase
foreach (char letter in input)
{      
  if (char.IsUpper(letter))
    count++;
}
Console.WriteLine("The wordcount is: {0}", count);