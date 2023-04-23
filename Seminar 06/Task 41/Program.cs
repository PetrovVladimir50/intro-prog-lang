// Задача №41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

string ReadDataStr(string msg)
{
    Console.Write(msg);
    string line = Console.ReadLine() ?? "0";
    return line;
}
int[] StrToIntArray(string data, string simbol)
{
    string[] arrayStr = data.Split($"{simbol}");

    int[] arrayInt = new int[arrayStr.Length];

    for (int i = 0; i < arrayStr.Length; i++)
    {
        arrayInt[i] = int.Parse(arrayStr[i]);
    }
    return arrayInt;
}

string numLine = ReadDataStr("Введите числа через пробел: ");
int[] nums = StrToIntArray(numLine," ");

int counter = 0;

foreach(int i in nums)
{
  if(i>0) counter++;
}

Console.WriteLine($"Чисел больше 0: {counter}");