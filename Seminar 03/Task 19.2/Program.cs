﻿// Задача №19: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Использовать Dictionary.

// Чтение данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Словарь 4-х значных палиндромов
var pallindroms = new Dictionary<int, bool>()
{
    {1001,true}, {1111,true}, {1221,true}, {1331,true}, {1441,true}, {1551,true}, {1661,true},
    {1771,true}, {1881,true}, {1991,true}, {2002,true}, {2112,true}, {2222,true}, {2332,true}, 
    {2442,true}, {2552,true}, {2662,true}, {2772,true}, {2882,true}, {2992,true}, {3003,true},
    {3113,true}, {3223,true}, {3333,true}, {3443,true}, {3553,true}, {3663,true}, {3773,true}, 
    {3883,true}, {3993,true}, {4004,true}, {4114,true}, {4224,true}, {4334,true}, {4444,true},
    {4554,true}, {4664,true}, {4774,true}, {4884,true}, {4994,true}, {5005,true}, {5115,true},
    {5225,true}, {5335,true}, {5445,true}, {5555,true}, {5665,true}, {5775,true}, {5885,true},
    {5995,true}, {6006,true}, {6116,true}, {6226,true}, {6336,true}, {6446,true}, {6556,true},
    {6666,true}, {6776,true}, {6886,true}, {6996,true}, {7007,true}, {7117,true}, {7227,true},
    {7337,true}, {7447,true}, {7557,true}, {7667,true}, {7777,true}, {7887,true}, {7997,true}, 
    {8008,true}, {8118,true}, {8228,true}, {8338,true}, {8448,true}, {8558,true}, {8668,true},
    {8778,true}, {8888,true}, {8998,true}, {9009,true}, {9119,true}, {9229,true}, {9339,true},
    {9449,true}, {9559,true}, {9669,true}, {9779,true}, {9889,true}, {9999,true}
};

int palindromKey = ReadData("Введите пятизначное число: ");

// Проверка на пятизначность
if (palindromKey<10000 || palindromKey>99999)
{
    Console.WriteLine("Не пятизначное число!");
}
else
{
    // Удаляю 3-ю цифру
    int twoFirst = palindromKey/1000;
    int twoLast = palindromKey%100;
    int newPalindromKey = twoFirst*100 + twoLast;
    if(pallindroms[newPalindromKey])Console.WriteLine("Данное число палиндром");
}








