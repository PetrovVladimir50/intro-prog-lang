// Задача №53: Задайте двумерный массив, напишите программу, которая поменяет местами
// первую и последнюю строчку масиива.
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
void SwapFirstAndLastLine(int[,] array)
{
  int temporary;
  int lastLine = array.GetLength(0)-1;
  for (int i = 0; i < array.GetLength(1); i++)
  {
    temporary = array[0, i];
    array[0, i] = array[lastLine, i];
    array[lastLine, i] = temporary;
  }
}

int[,] newArray = Gen2DArray(3, 5, 10, 99);
Print2DArray(newArray);
SwapFirstAndLastLine(newArray);
Console.WriteLine();
Print2DArray(newArray);
