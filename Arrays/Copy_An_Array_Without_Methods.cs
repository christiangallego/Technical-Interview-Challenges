// Copy an array to another array without using methods

Console.WriteLine("What number of elements should your array have?");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int[] arr2 = new int[n];
Console.WriteLine("Give each element a value: ");

    for (int i = 0; i < n; i++)
      {
        arr[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Element {0} is: {1}", i, arr[i]);
      }
      Console.Write("Here is your printed array: ");
      for (int i = 0; i < n; i++)
      {
        arr2[i] = arr[i];
        Console.Write(arr2[i]);             
      }
    Console.WriteLine("\n");