// Write a program that displays the longest word in a sentence
System.Console.WriteLine("Type your sentence here: ");

string sentence = Console.ReadLine();
string[] words= sentence.Split(' ');
string largestword = "";
  for (int i = 0; i < words.Length; i++)
    {
      if (words[i].Length > largestword.Length)
        largestword = words[i];        
    }
Console.Write("The largest word is {0}", largestword);