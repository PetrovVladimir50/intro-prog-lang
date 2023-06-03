// Задача №60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
int[,,] Gen3DArray(int x, int y, int z, int min, int max)
{
  int[,,] array = new int[x, y, z];
  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    {
      for (int l = 0; l < z; l++)
      {
        Random rnd = new Random();
        array[i, j, l] = new Random().Next(min, max + 1);
      }
    }
  }
  return array;
}
void Print3DArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int l = 0; l < arr.GetLength(2); l++)
      {
        Console.Write($"{arr[i, j, l]}({i}, {j}, {l})");
      }
    }
    Console.WriteLine();
  }
}

int[,,] matrix = Gen3DArray(3,3,3,10,99);
Print3DArray(matrix);


