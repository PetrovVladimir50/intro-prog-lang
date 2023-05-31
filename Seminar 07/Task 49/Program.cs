// Задача №49: Задайте двумерный массив, найдите элементы у которых оба индекса четный.
// Замените их на их квадраты.
int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
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
void Update2DArray(int[,] array, int numOfLines, int numOfColumns)
{
  for (int i = 0; i < numOfLines; i = i + 2)
  {
    for (int j = 0; j < numOfColumns; j = j + 2)
    {
      array[i, j] = array[i, j] * array[i, j];
    }
  }
}
void Print2DArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int numOfLines = ReadData("Введите m: ");
int numOfColumns = ReadData("Введите n: ");

int[,] arr = Gen2DArray(numOfLines, numOfColumns, 10, 0);
Print2DArray(arr);
Console.WriteLine();
Update2DArray(arr, numOfLines, numOfColumns);
Print2DArray(arr);

