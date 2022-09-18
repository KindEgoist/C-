/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] NumArray2d() 
{   
    Console.WriteLine("Программа, которая заполнит спирально симметричный массив");
    Console.Write("Введите число которое будет значением количество строк и столбцов: ");
    int sizeXY = Convert.ToInt32(Console.ReadLine());
    int rows = sizeXY;
    int columns = sizeXY;

    int[,] newArray = new int[rows, columns]; 
    
    int num = 1; 
        
    for (int size = 0; size < rows / 2 + 1 && size < columns / 2 + 1; size++)
    {

        for(int j = 0 + size; j < columns - size; j++) 
        {
            newArray [size,j] = num ;
            num ++;
        }
        for(int i = 1 + size; i < rows - size; i++) 
        {
            newArray [i,rows - 1 - size] = num;
            num ++;
        }
        
        
        for(int j = columns - 2 - size; j >= 0 + size; j--)
        {
            newArray [columns - 1 - size,j] = num ;
            num ++;
        }
        for(int i = rows - 2 - size; i >= 1 + size; i--)
        {
            newArray [i, size] = num ;
            num ++;
        }
        
    }
    return newArray;
}

void PrintArray2d(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($"0{array[i, j]}  ");
            else Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int[,] myArray = NumArray2d(); 
PrintArray2d(myArray);
