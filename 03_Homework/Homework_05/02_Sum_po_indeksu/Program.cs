/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] Random (int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return newArray;
}

void Print(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NeChet(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = Random(size, min, max);
Print(myArray);
Console.WriteLine($"Сумма элементов под нечетными индексами: {NeChet(myArray)}");