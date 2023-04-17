// Задача №34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
int NumberOfEven(int[] array)
{
  int result = 0;
  foreach (int i in array)
  {
    if (i % 2 == 0) result += 1;
  }
  return result;
}

int[] newArray = GenArray(10,100,999);
PrintArray1D(newArray);
Console.WriteLine(NumberOfEven(newArray));





