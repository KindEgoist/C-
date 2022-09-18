//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
 
void Transponirovanie(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++) 
        {            
            for(int j = 1; j < array.GetLength(1); j++) //for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j , i];
                array[j, i] = temp; 
            }
        }
    }
    else Console.WriteLine("Ошибка! \n");
}

int[,] myArray = RandomArray2d();
PrintArray2d(myArray); 
Transponirovanie(myArray);
PrintArray2d(myArray);
