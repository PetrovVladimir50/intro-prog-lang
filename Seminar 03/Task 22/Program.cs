// Задача №22: Вывести таблицу, где первая строка значения от 1 до N,
// а вторая - квадарты этих значений.

int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

string LineGen(int num, int pow)
{
    string result = String.Empty; // String.Empty = ""
    for (int i = 1; i < num + 1; i++)
    {
        result += Math.Pow(i, pow) + " ";
    }
    return result;
}

int num = ReadData("Введите число N: ");

string firstLine = LineGen(num, 1);
string secondLine = LineGen(num, 2);

Console.WriteLine(firstLine);
Console.WriteLine(secondLine);