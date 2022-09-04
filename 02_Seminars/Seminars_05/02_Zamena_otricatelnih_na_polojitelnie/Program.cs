// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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

int[] Znak(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= (-1);
    return array;
}

Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(size, min, max);
Print(myArray);
Print(Znak(myArray));