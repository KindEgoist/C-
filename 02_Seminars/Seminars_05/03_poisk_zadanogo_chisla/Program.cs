// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int [] RandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray; 
}

void Print (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

bool YesNo(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == num) 
        {
            return true;
        }
    return false;
        
}

Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(size, min, max);
Print(myArray);

Console.WriteLine(YesNo(myArray, num));