// Задача №11: Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// // Вариант 1
// int number = new Random().Next(100,1000);
// Console.WriteLine(number);

// int firstDigit = number/100;
// int lastDigit = number% 10;
// int newNumber = firstDigit*10 + lastDigit;

// Console.WriteLine(newNumber);

// Вариант 2
int number = new Random().Next(100,1000);
Console.WriteLine(number);
char[] digits = number.ToString().ToCharArray();
char[] result = {digits[0], digits[2]};
Console.WriteLine(result);