// Задача №38*: Отсортируйте массив методом вставки, а затем найдите разницу
// между первым и последним элементом.

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

int[] insertSort(int[] array)
{
  for (int i = 1; i < array.Length; i++)
  {
    int k = array[i];
    int j = i - 1;

    while (j >= 0 && array[j] > k)
    {
      array[j + 1] = array[j];
      array[j] = k;
      j--;
    }
  }
  return array;
}

int[] array1 = GenArray(10,-10,10);
PrintArray1D(array1);
array1 = insertSort(array1);
PrintArray1D(array1);

Console.WriteLine($"Разброс массива: {array1[array1.Length-1]-array1[0]}");



