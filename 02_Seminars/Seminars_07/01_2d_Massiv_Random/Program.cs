// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] RandomArray2d() //задаем 2х мерную функцию. Аргументы: строки, столбцы, мин значение, макс значение
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество стобцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Мин значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Макс значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns]; //инцилизация 2д массива
    
    for(int i = 0; i < rows; i++) //строки
        for(int j = 0; j < columns; j++) //столбци
            newArray [i,j] = new Random().Next(minValue, maxValue + 1); //рандомное заполнение массива
    return newArray;
}

void PrintArray2d(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
 
int[,] myArray = RandomArray2d();
PrintArray2d(myArray); 
