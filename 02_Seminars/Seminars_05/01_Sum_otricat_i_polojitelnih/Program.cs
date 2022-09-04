// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] CreateRandomArray(int size, int miniValue, int maxValue) // Функция создания рандомного массива
{
    int[] newArray = new int[size];// объявление массива 

    for(int i = 0; i < size; i++) //цикл генераци массива
        newArray[i] = new Random().Next(miniValue, maxValue + 1);// генерация рандомных значений 
    return newArray; //возващение значений в тело программы
}

void ShowArray(int [] array) //функция для вывода на экран масива
{
    for(int i = 0; i < array.Length; i++)//цикл вывода массива
        Console.Write(array[i] + " ");// вывод на экран элемента массива
    Console.WriteLine();
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) sum += array[i];
    return sum;
}

Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int positiveSum = FindPositiveSum(myArray);
int negativeSum = FindNegativeSum(myArray);

Console.WriteLine($"Сумма отрицательных {negativeSum} \nСумма положительных {positiveSum}"); // \n перенос на другую строку