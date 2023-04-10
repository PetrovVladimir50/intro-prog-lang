// Задача №20: Найти расстояние между двумя точками на плоскости (длину вектора)

int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

void vectorLength2D (int x1, int y1, int x2, int y2)
{
    int sumOfCubs = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1);
    Console.WriteLine(sumOfCubs);
    double length = Math.Sqrt(sumOfCubs);
    Console.WriteLine("Длина вектора: " + length);
}

int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите x2: ");
int x2 = ReadData("Введите y1: ");
int y2 = ReadData("Введите y2: ");

vectorLength2D (x1, y1, x2, y2);

