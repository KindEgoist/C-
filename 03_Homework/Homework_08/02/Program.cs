/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

void MinSumStr(int [,] array)
{   
    int str = 0;
    int minSum = 0;
    
    for(int i = 0; i < 1; i++)//находим Мин сумму 0 строки от которой будем отталкиваться
    {   
        for(int j = 0; j < array.GetLength(1); j++)
        {   
            minSum += array[i, j]; 
        }
    }

    for(int i = 0; i < array.GetLength(0); i++) //перебераем все строки и находим номер строки
    {   
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {   
            sum = sum + array[i, j]; 
        }
        if (sum < minSum)
        {
           // minSum = sum;
            str = i;
        }
        
    }
    //Console.WriteLine($"Мин сумма {minSum}");
    Console.WriteLine($"Номер строки {str + 1}");//чтоб понятней было какая строка нашлась добавил +1
     
       
}

Console.Clear();
int[,] myArray = RandomArray2d();
PrintArray2d(myArray); 
MinSumStr(myArray);
