// Задача №24: Напишите программу, которая принимает число А и выдает сумму чисел от 1 до A

int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

long SumSimple(int a)
{
    long result = 0;
    for (int i = 0; i <= a; i++)
    {
        result += i;
    }
    return result;
}

long SumGaus(int a)
{

    return ((1 + (long)a) * a / 2);
}

int a = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(a);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGaus(a);
Console.WriteLine(DateTime.Now - d2);

Console.WriteLine(res1);
Console.WriteLine(res2);