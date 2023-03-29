// Здача №14: Напишите программу, которая на вход принмает число
// и проверяет кратно ли оно однвременно и 7 и 23.

int num1 = int.Parse(Console.ReadLine()??"0");

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}