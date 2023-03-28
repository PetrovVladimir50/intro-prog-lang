// Задача: Найти индекс элемента, равного значению find
void FillArary(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
} 

void PrintArray(int[] collection)
{
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write(collection[index]);
        Console.Write(" ");
        index++;
    }
}

int IndexOf (int[] collection, int find)
{
    int size = collection.Length;
    int index = 0;
    int indexOfFind = 0;
    while (index < size)
    {
        if (collection[index] == find)
        {
            indexOfFind = index;
            indexOfFind++;
            break;
        }
        index++;
    }
    return indexOfFind;
}

int[] array = new int[10];

FillArary (array);
PrintArray (array);
Console.WriteLine();

int result = IndexOf (array, 8);
if (result == 0)
{
    Console.WriteLine("Нужного значения нет в списке.");
}
else
{
    Console.Write("Номер искомого значенния в списке: ");
    Console.WriteLine(result);
}