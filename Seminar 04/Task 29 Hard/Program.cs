// Задача №29*: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал.

Console.Write("Введите имена через запятую: ");
string? names = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми (как сделать метод и сократить проверку не понял)
if (names != null && names != String.Empty)
{
    string[] namesArray = names.Split(","); // Разделяем
    Console.WriteLine(namesArray[new Random().Next(0, namesArray.Length)]);
}
else
{
    Console.WriteLine("Перезапустите программу и введите имена!");
}
