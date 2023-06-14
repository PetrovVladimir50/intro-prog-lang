// Задача №64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}
void PrintNums(int n)
{
  if (n>=1)
  {
  Console.Write(n+" ");
  PrintNums(n-1);
  }
}
PrintNums(ReadData("Введите число: "));

