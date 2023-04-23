// Задача №42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

string DecToBin(int num)
{
  string res = "";
  while (num != 0)
  {
    res += num % 2;
    num = num / 2;
  }
  return res;
}

int number = ReadData("Введите число: ");
Console.WriteLine(DecToBin(number));