// Задача№?: Вывести первые N строк треугольника паскаля,
// делать вывод в виде равнобедренного треугольника. 
int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}
void Print2DArraySpecial(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i, j] == 0)
      {
        Console.Write(" ");
      }
      else
      {
        Console.Write(arr[i, j]);
      }
    }
    Console.WriteLine();
  }
}

int n = ReadData("Введите кол-во строк: ");
int[,] pascalTriangle = new int[n, (n * 2) + 1];
pascalTriangle[0, n] = 1;
int gaps = n;
for (int i = 1; i < n; i++)
{
  for (int j = gaps - 1; j < (n * 2) + 1; j++)
  {
    if (j != 0 && j != (n * 2))
    {
      pascalTriangle[i, j] = pascalTriangle[i - 1, j - 1] + pascalTriangle[i - 1, j + 1];
    }
  }
  gaps--;
}

Print2DArraySpecial(pascalTriangle);
