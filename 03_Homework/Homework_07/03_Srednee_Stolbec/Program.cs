// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] RandomArray2d() 
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество стобцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Мин значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Макс значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Полученная рандомно матрица: ");

    double[,] newArray = new double[rows, columns]; 
    
    for(int i = 0; i < rows; i++) 
        for(int j = 0; j < columns; j++) 
            newArray [i,j] = new Random().Next(minValue, maxValue + 1); 
    return newArray;
}

void PrintArray2d(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SredneeStolbec(double [,] array)
{
    int stolb = 1;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        Console.SetCursorPosition(40,5+stolb);
        Console.WriteLine($" Cреднее арифметическое столбца {stolb} = {sum / array.GetLength(1)} ");
        stolb++;
    }    
}

Console.Clear();
double[,] myArray = RandomArray2d();
PrintArray2d(myArray); 
SredneeStolbec(myArray);






