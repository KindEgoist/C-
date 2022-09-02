/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

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

int Chet(int[] array)
{
    int chet = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) chet++;
    }
    return chet;
}

Console.Clear();
Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = Random(size, 100, 999);
Print(myArray);
Console.WriteLine($"Количество четных чисел в массиве: {Chet(myArray)}");