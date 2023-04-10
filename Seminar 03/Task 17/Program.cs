// Задача №17: Определить четверть точки на плоскости по двум ее координатам
// Метод чтения данных пользователя (координаты отличные от нуля)
int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Метод определяет четверть точки по координатам
void PrintQuarterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка в 2 четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка в 4 четверти");
}

int coordinateX = ReadData("Введите координату X: ");
int coordinateY = ReadData("Введите координату Y: ");
PrintQuarterTest(coordinateX,coordinateY);