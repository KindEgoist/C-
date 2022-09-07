// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

int[] Fubonache(int size, int one, int two)
{   
    int sum = one;
    int[] newArray = new int[size];
    newArray[0] = one;
    newArray[1] = two;
    for(int i = 2; i < size; i++)
        newArray[i] = newArray[i - 2] + newArray [i - 1];
    return newArray;
}

void Print(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите значения количества чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое значение: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int two = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fubonache(size, one, two);
Print(myArray);
