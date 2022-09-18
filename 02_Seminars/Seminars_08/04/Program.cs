// Написать программу поэлементного копирования массива.

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
 
int [,] Copy(int[,] array)
{   
    int [,] newArray = new int [array.GetLength(0), array.GetLength(1) ];
    
    for(int i = 0; i < array.GetLength(0); i++) 
    {         
        
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            newArray[i, j] = array [i, j];
            
        }
        
    }
        
    return newArray;
}

int[,] myArray = RandomArray2d();
PrintArray2d(myArray); 

int[,] newArray = Copy(myArray);
 for(int i = 0; i < newArray.GetLength(0); i++) 
    {         
        
        for(int j = 0; j < newArray.GetLength(1); j++) 
        {
            newArray[i, j] += newArray[i, j];
            
        }
        
    }
PrintArray2d(newArray);
