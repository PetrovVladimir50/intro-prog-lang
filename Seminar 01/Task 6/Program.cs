// Задача №6: На вход принимает число и выдаёт, является ли число чётным.

// Ввод
string? numberLine = Console.ReadLine();

//Проверка на пустое значение
if (numberLine!=null)
{
    // Парсим
    int number = int.Parse(numberLine);

    // Вычисляем остаток от деления на 2
    int remainder = number % 2;

    // Проверка остатка
    if (remainder == 0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
}