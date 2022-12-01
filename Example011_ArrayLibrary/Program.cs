void FillArray(int[] collection) // Метод заполнения массива
{
    int length = collection.Length; // определение длины collection
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Метод печати (вывода) массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // new int[10] - создай новый массив, в котором будет 10 элементов

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
