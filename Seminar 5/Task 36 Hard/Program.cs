// Здача №36*: Найдите все пары в массиве и выведите пользователю

int[] GenArray(int size, int min, int max)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    Random rnd = new Random();
    array[i] = new Random().Next(min, max + 1);
  }
  return array;
}

void PrintArray1D(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + ",");
  }
  Console.WriteLine("]");
}

string Pairs(int[] array)
{
  string result = String.Empty;
  for (int i = 0; i < array.Length; i++)
  {
    for (int j = i + 1; j < array.Length - i - 1; j++)
    {
      if (array[i] == array[j])
      {
        result += $"[{array[i]},{array[j]}] ";
        break;
      }
    }
  }
  return result;
}

//int[] array1 = GenArray(10, 0, 10);
int[] array1 = {10,6,10,1,10,0,6,1,7,6}; // Решение не работает. Видно на примере этого массива
string result = Pairs(array1);           // Как красиво доработать, пока не понимаю
PrintArray1D(array1);
Console.WriteLine(result);