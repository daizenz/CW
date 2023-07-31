string[] less3(string[] ex1)
{
  int count = 0;
  for(int i = 0; i < ex1.Length; i++)
  {
    if(ex1[i].Length <= 3) 
    {
      count++;
    }
  }
  string[] arr = new string[count];

   count = 0;

  for(int i = 0; i < ex1.Length; i++)
  {
     if(ex1[i].Length <= 3)
     {
        arr[count] = ex1[i];
        count++;
     }
  }


  return arr;
}


string[] array = { "1245", "156", "-2", "computer science", "Hello", "2", "world", ":-)" };
string[] result = less3(array);
for(int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

