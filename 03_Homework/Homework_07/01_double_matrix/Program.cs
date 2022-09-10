// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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
        {
            newArray [i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(); 
            newArray[i, j] = Math.Round(newArray[i, j], 1); //сколько цифр отставить после запятой
        }
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
 
Console.Clear();
double[,] myArray = RandomArray2d();
PrintArray2d(myArray); 