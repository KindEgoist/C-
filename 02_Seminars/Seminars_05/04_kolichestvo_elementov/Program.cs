// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue);
    return newArray;
}

void Print(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Cif (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
    return count;
}

Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(size, min, max);
Print(myArray);

Console.WriteLine(Cif(myArray));