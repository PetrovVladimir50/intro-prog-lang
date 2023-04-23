// Задача №40: Напишите программу, которая принимает на вход 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длинны.

int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}

bool TrianTest(int a, int b, int c)
{

  if (a <= b + c && b <= a + c && c <= a + b) return true;
  return false;
}

int side1 = ReadData("Введите 1 сторону: ");
int side2 = ReadData("Введите 2 сторону: ");
int side3 = ReadData("Введите 3 сторону: ");

Console.WriteLine(TrianTest(side1, side2, side3));



