// Задача №36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumOfOddIndex(int[] array)
{
  int result = 0;
  for (int i = 1; i < array.Length; i += 2)
  {
    result += array[i];
  }
  return result;
}

int[] array1 = GenArray(10,-10,10);
PrintArray1D(array1);
int sum = SumOfOddIndex(array1);
Console.WriteLine(sum);
