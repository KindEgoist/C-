/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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
int[,] Proizvedenie(int[,] array, int[,] array2)
{
    int[,] finArray = new int[array.GetLength(0), array2.GetLength(1)]; //создаем новую матрицу которая будет содержать кол строк от первой матрицы и кол столбцов от второй матрицы
    
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {    
            for(int k = 0; k < array.GetLength(1); k++) 
            {
                finArray[i, j] += array[i, k] * array2[k, j]; //заносим произведение двух матриц в новую матрицу, где i-сторока первой матрицы, j-столбец второй матрицы, а k-столбец первой матрицы и строка второй матрицы
            }
        }
    }

    return finArray;         
}


Console.Clear();
int[,] myArray1 = RandomArray2d(); //создание первой матрицы
PrintArray2d(myArray1);
int[,] myArray2 = RandomArray2d();//создание второй матрицы
PrintArray2d(myArray2); 
int[,] fin = Proizvedenie(myArray1, myArray2);//результативная матрицы произведений двух матриц
PrintArray2d(fin); 
