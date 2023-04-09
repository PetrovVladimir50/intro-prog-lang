// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");

if (num<100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    char[] numArray = num.ToString().ToCharArray();
    Console.WriteLine("Третьяя цифра: " + numArray[2]);
}
