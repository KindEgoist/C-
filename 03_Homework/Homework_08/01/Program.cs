/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] RandomArray2d() 
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

    int[,] newArray = new int[rows, columns]; 
    
    for(int i = 0; i < rows; i++) 
        for(int j = 0; j < columns; j++) 
            newArray [i,j] = new Random().Next(minValue, maxValue + 1); 
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

void Puzerek(int [,] array)
{
    for (int n = 1; n < array.GetLength(1) * (array.GetLength(1) - 1); n++)// повторять столько раз сколько вариаций пар в строке
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1) - 1; j++)
            {   
                if (array[i, j] < array[i, j + 1]) //условие сортировки пузырьком
                {
                    int temp = array[i, j];
                    array[i, j] = array [i, j + 1];
                    array [i, j + 1] = temp;
                }
            }
        }
    }
}

Console.Clear();
int[,] myArray = RandomArray2d();
PrintArray2d(myArray); 
Puzerek(myArray);
Console.WriteLine("Отсортированная матрица: ");
PrintArray2d(myArray); 


