// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
double ReadData(string msg)
{
  Console.Write(msg);
  double result = double.Parse(Console.ReadLine() ?? "0");
  return result;
}

double k1 = ReadData("Введите k1: ");
double b1 = ReadData("Введите b1: ");
double k2 = ReadData("Введите k2: ");
double b2 = ReadData("Введите b2: ");

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine($"Точка пересечения: {x},{y}");