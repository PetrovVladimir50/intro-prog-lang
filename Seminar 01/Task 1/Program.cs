// Задача: найти квадрат числа

// Считываем данные из консоли
string? inLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if (inLine != null)
{   // Парсим введенное число
    int inNumber = int.Parse(inLine);
    // Находим введенное число
    int outNumber = inNumber*inNumber;
    // Выводим данные в консоль
    Console.WriteLine(outNumber);
}
