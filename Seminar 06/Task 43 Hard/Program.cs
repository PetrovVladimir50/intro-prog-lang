// * Найдите площадь треугольника образованного пересечением 3 прямых
void RandomTriangle()
{
  double vectorLength2D(double x1, double y1, double x2, double y2)
  {
    double sumOfCubs = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
    double length = Math.Sqrt(sumOfCubs);
    return length;
  }

  double[] indexes = new double[6];
  for (int i = 0; i < indexes.Length; i++)
  {
    indexes[i] = new Random().Next(-20, 20);
  }

  Console.WriteLine($"y = {indexes[0]}x + {indexes[1]}");
  Console.WriteLine($"y = {indexes[2]}x + {indexes[3]}");
  Console.WriteLine($"y = {indexes[4]}x + {indexes[5]}");

  if (indexes[0] == indexes[2] || indexes[0] == indexes[4] || indexes[2] == indexes[4])
  {
    Console.WriteLine("Прямые паралельны, треугольника не образуют.");
  }
  else
  {
    double x1 = Math.Round((indexes[3] - indexes[1]) / (indexes[0] - indexes[2]), 2);
    double y1 = Math.Round(indexes[0] * x1 + indexes[1], 2);

    double x2 = Math.Round((indexes[5] - indexes[1]) / (indexes[0] - indexes[4]), 2);
    double y2 = Math.Round(indexes[0] * x2 + indexes[1], 2);

    double x3 = Math.Round((indexes[3] - indexes[5]) / (indexes[4] - indexes[2]), 2);
    double y3 = Math.Round(indexes[2] * x3 + indexes[3], 2);

    Console.WriteLine($"Точки пересечения: {x1}  {y1} | {x2}  {y2} | {x3}  {y3}");

    double side1 = vectorLength2D(x1, y1, x2, y2);
    double side2 = vectorLength2D(x1, y1, x3, y3);
    double side3 = vectorLength2D(x2, y2, x3, y3);

    double p = (side1 + side2 + side3) / 2; // semiPerimeter
    double area = Math.Round(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)), 2); // Формула Герона
    Console.WriteLine($"Площать треугольника: {area}");
  }
}

RandomTriangle();