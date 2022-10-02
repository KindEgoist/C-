/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

void Search(string[] arrayString)
{
    string[] arrayResult = new string[arrayString.Length];

    int count = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if(arrayString[i].Length <= 3)
        {
            arrayResult[count] = arrayString[i];
            count++;
        }
    }
    for (int i = 0; i < arrayResult.Length; i++)
    {
        Console.Write($"{arrayResult[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();

string[] arrayString = new string[10] {"hello", "2", "world", ":-)", "1234", "1567", "-2", "Хай", "Yo!", "Kazan"};

Search(arrayString);
