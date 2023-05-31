// Задача №51: Задайте двумерный массив, найдите сумму элементов,
// находящихся на главной диагонале (0,0; 1,1).

int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}
void Print2DArray(int[,] arr)
{
  ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Blue };
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i == j)
      {
        Console.ForegroundColor = col[0];
        Console.Write(arr[i, j] + " ");
        Console.ResetColor();
      }
      else
      {
        Console.Write(arr[i, j] + " ");
      }
    }
    Console.WriteLine();
  }
}
int[,] Gen2DArray(int numOfLines, int numOfColumns, int max, int min)
{
  int[,] array = new int[numOfLines, numOfColumns];
  for (int i = 0; i < numOfLines; i++)
  {
    for (int j = 0; j < numOfColumns; j++)
    {
      Random rnd = new Random();
      array[i, j] = new Random().Next(min, max + 1);
    }
  }
  return array;
}
int SumOfDiagonal(int[,] array)
{
  int sum = 0;
  int limit = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);
  for (int i = 0; i < limit; i++)
  {
    sum += array[i, i];
  }
  return sum;
}

int numOfLines = ReadData("Введите m: ");
int numOfColumns = ReadData("Введите n: ");

int[,] arr = Gen2DArray(numOfLines, numOfColumns, 10, 1);
int sum = SumOfDiagonal(arr);

Print2DArray(arr);
Console.WriteLine();
Console.WriteLine("Сумма диагонали: " + sum);