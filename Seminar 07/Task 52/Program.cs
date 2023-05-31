// Задача №52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] Gen2DArray(int numOfLines, int numOfColumns, int min, int max)
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
int[] AverageInColumn(int[,] array)
{
  int[] outArray = new int[array.GetLength(0)];
  for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      outArray[i] += array[j, i];
    }
    outArray[i] = outArray[i]/array.GetLength(0);
  }
  return outArray;
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
void PrintArray1D(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[,] arr = Gen2DArray(5,4,10,99);
Print2DArray(arr);
int[] outArray = AverageInColumn(arr);
Console.WriteLine();
PrintArray1D(outArray);



