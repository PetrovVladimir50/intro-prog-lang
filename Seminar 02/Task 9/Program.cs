// Задача №9: 
// Напишите программу, которая выводит случайное число и отрезка 10-99,
// показывает наибольшую цифру этого числа.

// int number = new Random().Next(10,99);
// Console.WriteLine(number);

System.Random numSintezator = new System.Random();

// Вариант 1
int rndNum = numSintezator.Next(10,100);
Console.WriteLine(rndNum);

short firstDigit = (short)(rndNum/10); // Преобразование int в short
short secondDigit = (short)(rndNum % 10);

Console.Write("Наибольшая цифра: ");

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}
// Вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNum = (int) (digits[0]-48);
int secondNum = (int) (digits[1]-48);
// Тернарный оператор
int result = (firstNum > secondNum)? firstNum:secondNum;
Console.WriteLine(result);
