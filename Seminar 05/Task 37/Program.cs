// Задача №37: Найдите произведение пар чисел в одномерном массиве
// (парой считается например первый и последний элемент).
// Результат запишите в новый массив.

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

void PrintChart2Lines(string[] topArray, string[] lowerArray)
{
  // Инициализирую пустые строки
  string topLine = "\u250C";
  string bottomLine = "\u2514";
  string divisionLine = "\u251c";
  string topArrayLine = "\u2502";
  string lowerArrayLine = "\u2502";

  for (int i = 0; i < topArray.Length; i++)
  {
    // Нахожу длину элемента 1 строки
    int element1Length = topArray[i].Length;

    // Нахожу длину элемента 2 строки
    int element2Length = lowerArray[i].Length;

    if (element1Length < element2Length)
    {
      topArrayLine += topArray[i] + String.Concat(Enumerable.Repeat(" ", element2Length - element1Length)) + "\u2502";
      lowerArrayLine += lowerArray[i] + "\u2502";

      int buffer = element2Length;
      element2Length = element1Length;
      element1Length = buffer;
    }
    else
    {
      topArrayLine += topArray[i] + "\u2502";
      lowerArrayLine += lowerArray[i] + String.Concat(Enumerable.Repeat(" ", element1Length - element2Length)) + "\u2502";
    }

    topLine += String.Concat(Enumerable.Repeat("\u2500", element1Length)) + "\u252C";

    divisionLine += String.Concat(Enumerable.Repeat("\u2500", element1Length)) + "\u253C";

    bottomLine += String.Concat(Enumerable.Repeat("\u2500", element1Length)) + "\u2534";
  }

  void PrintLine(string line)
  {
    for (int i = 0; i < line.Length; i++)
    {
      Console.Write(line[i]);
    }
    Console.WriteLine();
  }

  PrintLine(topLine);
  PrintLine(topArrayLine);
  PrintLine(divisionLine);
  PrintLine(lowerArrayLine);
  PrintLine(bottomLine);
}

int[] array1 = GenArray(10, 1, 10);
int[] newArray = new int[array1.Length / 2];
int lastEl = array1.Length - 1;

for (int i = 0; i < newArray.Length; i++)
{
  newArray[i] = array1[i] * array1[lastEl];
  lastEl--;
}

string[] result1 = new string[newArray.Length];
string[] result2 = new string[newArray.Length];

lastEl = array1.Length - 1;

for (int i = 0; i < newArray.Length; i++)
{
  result1[i] = $"{array1[i]} * {array1[lastEl]}";
  result2[i] = newArray[i].ToString();
  lastEl--;
}

PrintArray1D(array1);

PrintChart2Lines(result1,result2);