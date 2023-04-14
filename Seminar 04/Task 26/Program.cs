// Задача №26: Напишите программу, которая принимает на вход число
// и выдает кол-во цифр в этом числе.

int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int LengthOfNum1(long num)
{
    char[] numLine = num.ToString().ToCharArray();
    return numLine.Length;
}

int LengthOfNum2(long num)
{
    int res = 0;
    while (num>0)
    {
        res++;
        num = num/10;
    }
    return res;
}

long num = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = LengthOfNum1(num);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = LengthOfNum2(num);
Console.WriteLine(DateTime.Now - d2);

Console.WriteLine("Цифр в числе: ");
Console.WriteLine(res1);
Console.WriteLine(res2);
