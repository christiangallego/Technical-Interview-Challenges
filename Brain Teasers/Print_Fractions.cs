// Print out the fraction equivalent of a user's input of any positive, negative and zero integers
  
  Console.WriteLine("What number of elements should your array have?");
  int n = int.Parse(Console.ReadLine());
  int[] arr = new int[n];
  int pos=0, neg=0, zer=0;
  Console.WriteLine("Give each element a value: ");
  for (int i = 0; i < n; i++)
  {
    arr[i] = int.Parse(Console.ReadLine());
    Console.WriteLine($"Element {i}: {arr[i]}");
  }
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
      pos++;      
    else if (arr[i]<0)
      neg++;
    else
      zer++;
  }
  Console.WriteLine("\n");
  Console.WriteLine($"The fraction of positives is {pos}/{n} ");
  Console.WriteLine($"The fraction of negatives is {neg}/{n} ");
  Console.WriteLine($"The fraction of zeros is {zer}/{n} ");