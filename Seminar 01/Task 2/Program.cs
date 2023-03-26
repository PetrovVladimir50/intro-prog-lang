// Задача №2: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Ввод первого числа
Console.Write("Enter first number: ");
string? number1Line = Console.ReadLine();
// Ввод второго числа
Console.Write("Enter second number: ");
string? number2Line = Console.ReadLine();
// Проверка на пустое значение
if (number1Line!=null && number2Line!=null)
{
    // Парсим
    int number1 = int.Parse(number1Line);
    int number2 = int.Parse(number2Line);

    // Проверка
    if (number1>number2)
    {
        Console.Write("max: ");
        Console.WriteLine(number1);
        Console.Write("min: ");
        Console.WriteLine(number2);
    }
    else
    {
        Console.Write("max: ");
        Console.WriteLine(number2);
        Console.Write("min: ");
        Console.WriteLine(number1);
    }
}
