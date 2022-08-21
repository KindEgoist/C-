//метод заполнения массива

void FillArray(int[] collection) //void не возвращает данные массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; //определение саммива из 10 элементов

FillArray(array); //заполнение массива
PrintArray(array); //распечатка массива