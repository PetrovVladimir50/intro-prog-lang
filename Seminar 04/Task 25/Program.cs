// Задача №25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// (цикл???)

int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int a = ReadData("Введите число A: ");
int b = ReadData("Введите число B: ");

// Проверка на натуральность
if (b>0) Console.WriteLine(Math.Pow(a,b));