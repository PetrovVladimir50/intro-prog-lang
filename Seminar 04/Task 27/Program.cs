// Задача №27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Данные пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Находит сумму
int SumOfNum(int num)
{
    int result = 0;
    char[] numLine = num.ToString().ToCharArray(); // Способ медленный, но красивый
    Console.WriteLine(numLine[0]);
    for (int i = 0; i < numLine.Length; i++)
    {
        result += numLine[i]-48; // ASCII кодировка
    }
    return result;
}

int number = ReadData("Введите число: ");
Console.WriteLine("Сумма его цифр: " + SumOfNum(number));

