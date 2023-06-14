// Задача №67: Посчитать сумму цифр в числе.(рекурентно)

int ReadData(string msg)
{
  Console.Write(msg);
  int result = int.Parse(Console.ReadLine() ?? "0");
  return result;
}

int SumDigitRec(int num)
{
  if (num>0)
  {
  return num % 10 + SumDigitRec(num/10);
  }
  else
  {
    return 0;
  }
}

int x = ReadData("Введите число: ");
int result = SumDigitRec(x);
Console.WriteLine(result);


