// Напишите программу, которая выводит массив из 10 элементов, заполненный нулями и единицами в случайном порядке.
/*
void FillArray(int[] collection) //2) создание функции для заполнениея рандомно массива
{
    int length = collection.Length; // объявление переменной lenght и присваеваем ей длину массива, в нашем случае до 10 элементов
    for (int index = 0; index < length; index++)// цикл фор и в нем объявлена переменная индекс, пока индекс < длины массива будет выполнятся следующие действие в цикле фор, так же индекс будем каждый раз увеличивать на 1
    {    
        collection[index] = new Random().Next(0, 2); // в наш массив мы вкладываем рандомно значения 0 и 1 
    }
}
void PrintArray (int[] col) //3) создаем функцию для печачати массива(чтоб показал в консоли массив)
{
    int count = col.Length;// объявление переменной count и присваеваем ей длину массива, в нашем случае до 10 элементов
    for (int position = 0; position < count; position++) // перебегает по всему массиву по индексам
    {    
        Console.Write($"{col[position]} ");// и выдает в консоле его значения
    }
}

int [] array = new int[10]; //1) Объявление о существование массива и то что в нем будет 10 элементов
FillArray(array);
PrintArray(array);*/

int[] FillArray(int size, int minValue, int maxValue) 
{
    int[] newArray = new int[size]; 
    for (int index = 0; index < size; index++)
    {    
        newArray[index] = new Random().Next(minValue, maxValue + 1); 
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

PrintArray(FillArray(8, 0, 1));