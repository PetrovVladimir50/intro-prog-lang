// Задача №18: Показать по заданному номеру четверти диапазон
// координат точек в этой четверти

Console.Clear();

int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

void PrintAnswer(int quarterNum)
{
    if (quarterNum == 1) Console.WriteLine("x>0,y>0");
    if (quarterNum == 2) Console.WriteLine("x<0,y>0");
    if (quarterNum == 3) Console.WriteLine("x<0,y<0");
    if (quarterNum == 4) Console.WriteLine("x>0,y<0");
}

int quarter = ReadData("Введите номер четверти: ");
if (quarter > 0 && quarter < 5)
{
    PrintAnswer(quarter);
}
else
{
    Console.WriteLine("Не четверть.");
}