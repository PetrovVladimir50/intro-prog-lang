// Задача №28: Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N.
using System.Numerics;


int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

BigInteger Factorial(int num)
{
    BigInteger res = 1;
    for (int i = 1; i < num+1; i++)
    {
        res = res * i;
    }
    return res;
}

int number = ReadData("Введите число: ");
Console.WriteLine(Factorial(number));
