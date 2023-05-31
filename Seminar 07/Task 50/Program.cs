// Задача №50: Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру.
int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}
void Print2DArray(int[,] arr)
{
  int line = ReadData("Введите строку элемента: ") - 1;
  int column = ReadData("Введите столбец элемента: ") - 1;

  ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,
  ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
  ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
  ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,
  ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i == line & j == column)
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

int[,] fibonachi = new int[,] { { 1, 1, 2, 3, 5 }, { 8, 13, 21, 34, 55 }, { 89, 144, 233, 377, 610 } };

Print2DArray(fibonachi);

