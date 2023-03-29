// Задача №16: Напишите программу, которая принмает на вход два числа
// и проверят, является ли одно число квадратом другого.

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

void Test (int a, int b)
{
    if (a == b*b)
    {
        Console.WriteLine(a + " квадарат " + b);
    }
    else
    {
        Console.WriteLine(a + " не квадарат " + b);
    }
}

Test(num1, num2);
Test(num2, num1);