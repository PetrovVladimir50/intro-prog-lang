// Задача №66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N включительно.
int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}
int SumBetweenNums(int a, int b)
{
  if (a<=b)
  {
  return a+SumBetweenNums(a+1,b);
  }
  else
  {
    return 0;
  }
}

Console.WriteLine(SumBetweenNums(ReadData("А: "), ReadData("B: ")));




