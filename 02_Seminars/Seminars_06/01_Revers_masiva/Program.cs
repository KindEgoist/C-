// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] Random(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue,maxValue + 1);
    return newArray;
}

void Print(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] Revers(int[] array)
{
    //for(int i = 0; i < array.Length / 2; i++) вариант без переменной j. С переменной j лучше вариант
    for(int i = 0, j = array.Length - 1; i < j ; i++, j--) // вариант переменная j
    {
        //int temp = array[i];
        int temp = array[i];
        //array[i] = array[array.Length -1 - i];
        array[i] = array[j];
        //array[array.Length - 1 - i] = temp;
        array[j] = temp;
    }
    return array;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = Random(size, min, max);
Print(myArray);
myArray = Revers(myArray);
Print(myArray);
