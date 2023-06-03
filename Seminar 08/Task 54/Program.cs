// Задача №54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
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
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
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
void Sort2DArrayRows(int[,] array)
{
  int[] tempArray = new int[array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      tempArray[j] = array[i, j];
    }
    BubbleSort(tempArray);
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, array.GetLength(1)-j-1] = tempArray[j];
    }
  }
}

int[,] matrix = Gen2DArray(10,10,10,99);
Print2DArray(matrix);
Console.WriteLine();
Sort2DArrayRows(matrix);
Print2DArray(matrix);