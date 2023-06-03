// Задача №55: Задайте двумерный массив, напишите программу, которая заменяет строки на столбцы.
// В случае, если это нвозможно, программа должна вывести сообщение для пользователя.
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
int[,] Transposition2DArray(int[,] array)
{
  int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      newArray[j,i]=array[i,j];
    }
  }
  return newArray;
}

int[,] matrix = Gen2DArray(3, 5, 10, 99);
Print2DArray(matrix);
Console.WriteLine();
int[,] transposedMatrix = Transposition2DArray(matrix);
Print2DArray(transposedMatrix);

