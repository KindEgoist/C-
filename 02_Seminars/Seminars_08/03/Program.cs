//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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
 
int [,] Transponirovanie(int[,] array)
{   
    int rows = array.GetLength(0); //количество строк в оригинальном массиве
    int columns = array.GetLength(1); //количество столбцов в оригинальном массиве
    int [,] newArray = new int [rows - 1, columns - 1];// создание нового массива на 1 столбец и на одну строку меньше
    int min = array[0, 0];
    int minRow = 0;
    int minColumn = 0;

    for(int i = 0; i < rows; i++) 
    {           
        for(int j = 0; j < columns; j++) 
        {
            if(min > array[i, j]) 
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    
    int m = 0;
    for(int i = 0; i < rows; i++) 
    {   
        if (i == minRow) continue;
        int n = 0;
        for(int j = 0; j < columns; j++) 
        {
            if(j == minColumn) continue;
            newArray[m, n] = array[i, j]; 
            n++;
        }
        m++;
    }
    return newArray;
    
}

int[,] myArray = RandomArray2d();
PrintArray2d(myArray); 
int[,] newArray = Transponirovanie(myArray);
PrintArray2d(newArray);
