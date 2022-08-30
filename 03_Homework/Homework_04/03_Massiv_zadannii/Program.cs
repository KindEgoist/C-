/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] FillArray(int size) 
{
    int[] newArray = new int[size]; 
    int num = 1;
    for (int index = 0; index < size; index++)
    {    
        Console.Write($"Введите {num} элемент массива: ");
        newArray[index] = Convert.ToInt32(Console.ReadLine()); 
        num++;
    }
    return newArray;
}
void PrintArray (int[] col) 
{
    for (int position = 0; position < col.Length; position++) 
    {    
        Console.Write($"{col[position]} ");
    }
    Console.WriteLine();
}
Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая запрашивает размер массива и элементы массива и выводит их на экран.==");
Console.SetCursorPosition(0, 10);
Console.Write("Введите размер массива: ");
int s = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray(s));