// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
 
void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    else
    {
        Console.WriteLine("Ошибка");
    }
};

int[,] myArray = RandomArray2d();
PrintArray2d(myArray); 
ChangeRows(myArray, 2, 5);
PrintArray2d(myArray);

