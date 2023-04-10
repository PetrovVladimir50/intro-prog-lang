// Задача №23: Вывести таблицу, где первая строка значения от 1 до N,
// а вторая - кубы этих значений. Построить в консоли таблицу.

Console.Clear();

int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

void LinesGen(int num, int pow)
{
    // Инициализирую пустые строки
    string result1 = String.Empty;
    string result2 = String.Empty;
    string divisionLine = String.Empty;
    string upDownLine = String.Empty;

    for (int i = 1; i < num + 1; i++)
    {
        // Нахожу длину числа в кубе
        string numLine1 = Math.Pow(i, pow).ToString();
        int numLength1 = numLine1.Length;

        // Нахожу длину исходного числа
        string numLine2 = i.ToString();
        int numLength2 = numLine2.Length;

        // Формирую строки
        result2 += Math.Pow(i, pow) + "|";

        result1 += i + String.Concat(Enumerable.Repeat(" ", numLength1-numLength2)) + "|";

        divisionLine += String.Concat(Enumerable.Repeat("-", numLength1)) + "|";

        upDownLine += String.Concat(Enumerable.Repeat("-", numLength1+1));
    }
    // Вывожу строки
    Console.WriteLine(upDownLine);
    Console.WriteLine(result1);
    Console.WriteLine(divisionLine);
    Console.WriteLine(result2);
    Console.WriteLine(upDownLine);
}

int num = ReadData("Введите число N: ");

LinesGen(num,3);