// Ввод значений
Console.Write("Enter first number: ");
string? num1Line = Console.ReadLine();
Console.Write("Enter second number: ");
string? num2Line = Console.ReadLine();
Console.Write("Enter third number: ");
string? num3Line = Console.ReadLine();

// Проверка на пустое занчение
if (num1Line!=null && num2Line!=null && num3Line!=null)
{
    // Парсим
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

    int maxnum = 0; // Чтобы maxnum был в области видимости всех циклов

    // Проверка
    if (num1>num2)
    {
        maxnum = num1;
    }
    else
    {
        maxnum = num2;
    }

    if (num3>maxnum)
    {
        maxnum = num3;
    }
    // Вывод
    Console.Write("Max number: ");
    Console.Write(maxnum);
}
