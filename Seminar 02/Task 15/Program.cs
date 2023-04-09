// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недли: ");
int day = int.Parse(Console.ReadLine()??"0");

string[] week = new string[7];
week[0] = "Понедельник";  week[1] = "Вторник";  week[2] = "Среда";  week[3] = "Четверг";
week[4] = "Пятница";  week[5] = "Суббота";  week[6] = "Воскресенье";

if (day<8 && day>0)
{
    if (day>5)
    {
        Console.Write("Выходной: ");
        Console.WriteLine(week[day-1]);
    }
    else
    {
        Console.Write("Рабочий день: ");
        Console.WriteLine(week[day-1]);
    }
}
else
{
    Console.WriteLine("Не день недели.");
}
