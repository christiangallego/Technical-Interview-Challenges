// Write a program that reverses a string w/o using built in functions
    
Console.WriteLine("Type input here: ");
string word = Console.ReadLine();
string reverseWord = "";
for (int i = word.Length-1; i >= 0; i--)
{ 
  reverseWord += word[i];
}
Console.WriteLine(reversedWord);       