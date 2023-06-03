// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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
void Print2DArray(int[,] arr)
{
  ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue};
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      // if (i == sums[matrix.GetLength(0)-1])
      // {
      // Console.ForegroundColor = col[0];
      // Console.Write(arr[i, j] + " ");
      // Console.ResetColor();
      // }
      // else
      // {
      Console.Write(arr[i, j] + " ");
      // }
    }
    Console.WriteLine();
  }
}
void BubbleSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    for (int j = 0; j < array.Length - 1; j++)
    {
      if (array[j] > array[j + 1])
      {
        int buffer = array[j];
        array[j] = array[j + 1];
        array[j + 1] = buffer;
      }
    }
  }
}

int[,] matrix = Gen2DArray(10, 10, 10, 99);
int[] sums = new int[matrix.GetLength(0)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  int sumOfRow =0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    sumOfRow+=matrix[i,j];
  }
  sums[i] = sumOfRow;
}
BubbleSort(sums);
Print2DArray(matrix);
Console.WriteLine();
Console.WriteLine($"Строка с наибольшей суммой элементов {matrix.GetLength(0)-1}: {sums[matrix.GetLength(0)-1]}");



