// Задача №59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.
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
void Print2DArrayColor(int[,] arr, int[] coords)
{
  ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,
  ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
  ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
  ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,
  ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i == coords[0] && j == coords[1])
      {
        Console.ForegroundColor = col[3];
        Console.Write(arr[i, j] + " ");
        Console.ResetColor();
      }
      else if (i == coords[0] || j == coords[1])
      {
        Console.ForegroundColor = col[13];
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
int[] FindMinValue(int[,] array)
{
  int[] coordinates = { 0, 0 };
  int minValue = array[0, 0];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      if (array[i, j] < minValue)
      {
        minValue = array[i, j];
        coordinates[0] = i;
        coordinates[1] = j;
      }
    }
  }
  return coordinates;
}
int[,] DelеteLine(int[,] array, int lineCord)
{
  int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)];
  int x = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (i == lineCord) continue;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result[x, j] = array[i, j];
    }
    x++;
  }
  return result;
}
int[,] DelеteColumn(int[,] array, int columnCord)
{
  int[,] result = new int[array.GetLength(0), array.GetLength(1)-1];
  int x = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    x = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j == columnCord) continue;
      result[i, x] = array[i, j];
      x++;
    }
  }
  return result;
}

Console.Clear();
int[,] matrix = Gen2DArray(10, 10, 10, 99);
int[] minValueCoordinates = FindMinValue(matrix);
Print2DArrayColor(matrix, minValueCoordinates);
Console.WriteLine();
Console.WriteLine("Min: "+minValueCoordinates[0] + "," + minValueCoordinates[1]);
Console.WriteLine();
int[,] newArray1 = DelеteLine(matrix, minValueCoordinates[0]);
int[,] newArray2 = DelеteColumn(newArray1, minValueCoordinates[1]);
Print2DArray(newArray2);