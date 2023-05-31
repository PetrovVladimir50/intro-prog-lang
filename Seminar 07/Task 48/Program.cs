// Задача №48: Задайте двумерный массив размером M на N. Каждый элемент в массиве
// находится по формуле a=m+n. Выведите полученный массив на экран.

int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}

void Fill2DArray(int[,] array, int numOfLines, int numOfColumns)
{
  for (int i = 0; i < numOfLines; i++)
  {
    for (int j = 0; j < numOfColumns; j++)
    {
      array[i, j] = i+j;
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

int numOfLines = ReadData("Введите М: ");
int numOfColumns = ReadData("Введите N: ");

int[,] array = new int[numOfLines, numOfColumns];

Fill2DArray(array, numOfLines, numOfColumns);

Print2DArray(array);
