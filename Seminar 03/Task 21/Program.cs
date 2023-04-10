// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Чтение данных пользователя
double ReadData(string msg)
{
    Console.Write(msg);
    double result = double.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Длина вектора
void vectorLength2D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double sumOfCubs = Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2);
    double length = Math.Sqrt(sumOfCubs);
    Console.WriteLine("Длина вектора: " + length);
}

double x1 = ReadData("Введите x1: ");
double y1 = ReadData("Введите y2: ");
double z1 = ReadData("Введите z1: ");
double x2 = ReadData("Введите x1: ");
double y2 = ReadData("Введите y2: ");
double z2 = ReadData("Введите z2: ");

vectorLength2D (x1, y1, z1, x2, y2, z2);


