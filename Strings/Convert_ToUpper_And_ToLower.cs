// Write a program that converts uppercase letters to lower case and vice versa
            
Console.WriteLine("Type your input here: ");
string input = Console.ReadLine();

  for (int i = 0; i < input.Length; i++)
  {
    if (Char.IsLower(input[i]))
      Console.Write(Char.ToUpper(input[i])); 
    else
      Console.Write(Char.ToLower(input[i]));
  }
  Console.WriteLine("\n");