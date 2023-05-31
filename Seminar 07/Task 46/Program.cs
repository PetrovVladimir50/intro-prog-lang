// Задача №46: Задайте двумерный массив размера M на N, заполненный случайными целыми числами.

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
void Print2DArray(int[,] arr)
{
  ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
  ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
  ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
  ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green};

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.ForegroundColor = col[new Random().Next(0,12)];
      Console.Write(arr[i, j] + " ");
      Console.ResetColor();
    }
    Console.WriteLine();
  }
}

int numOfLines = ReadData("Введите m: ");
int numOfColumns = ReadData("Введите n: ");

int[,] arr = Gen2DArray(numOfLines, numOfColumns, 99, 10);

Print2DArray(arr);
