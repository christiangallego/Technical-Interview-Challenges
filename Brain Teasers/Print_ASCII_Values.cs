// Print all ascii values and their numbers using a while loop

  int i = 0;
  while (i<=255)
  {
    Console.WriteLine("{0} = {1}", i, convert.ToChar(i));
    i++;
  }