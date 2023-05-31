// Задача №47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}
double[,] Gen2DArrayDouble(int numOfLines, int numOfColumns, int min, int max)
{
  double[,] array = new double[numOfLines, numOfColumns];
  for (int i = 0; i < numOfLines; i++)
  {
    for (int j = 0; j < numOfColumns; j++)
    {
      Random rnd = new Random();
      array[i, j] = new Random().Next(min, max-1) + Math.Round(new Random().NextDouble(), 2);
    }
  }
  return array;
}
void Print2DArray(double[,] arr)
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
      Console.ForegroundColor = col[new Random().Next(0, 16)];
      Console.Write(arr[i, j] + " ");
      Console.ResetColor();
    }
    Console.WriteLine();
  }
}

int numOfLines = ReadData("Введите m: ");
int numOfColumns = ReadData("Введите n: ");

double[,] arr = Gen2DArrayDouble(numOfLines, numOfColumns, 0, 10);

Print2DArray(arr);



