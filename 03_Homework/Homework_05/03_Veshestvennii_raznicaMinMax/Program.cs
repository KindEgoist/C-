/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] Random(int size, int minValue, int maxValue)
{
    double[] newArray = new double [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1) + new Random().NextDouble();
    }
    return newArray;
}

void Print(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MinMax(double[] array)
{
    double raznica = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }
    raznica = max - min;
    return raznica;
}

Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = Random(size, min, max);
Print(myArray);
Console.WriteLine($"Разница между Max и Min элементов массива: {MinMax(myArray)}");
