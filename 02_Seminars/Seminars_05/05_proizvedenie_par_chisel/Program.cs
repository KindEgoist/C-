// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] Para(int [] array)
{
    int[] newArray = new int [array.Length/2];
    int count = 1;
    for (int i = 0; i < array.Length/2; i++)
    {
        newArray[i] = array[i] * array[array.Length - count];
        count++;
    }
    return newArray;
}

Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(size, min, max);
Print(myArray);
int[] newArray = Para(myArray);
Print(newArray);