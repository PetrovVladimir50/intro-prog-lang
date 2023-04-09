// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите 3-х значное число: ");
int num = int.Parse(Console.ReadLine()??"0");

// // 1 Вариант
// if(num>=100 && num<=999)
// {
//     num = num/10;
//     int result = num%10;
//     Console.WriteLine("Вторая цифра: " + result);
// }
// else
// {
//     Console.WriteLine("Не 3-х знчное число");
// }

// 2 Вариант
char[] numArray = num.ToString().ToCharArray();
Console.WriteLine("Вторая цифра: " + numArray[1]);