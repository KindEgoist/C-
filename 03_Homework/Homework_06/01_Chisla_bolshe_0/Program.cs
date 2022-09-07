/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int Count(int num)
{
    int i = 1;
    int count = 0;
    while (num > 0)
    {
        Console.Write($"Введите {i} число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0) count++;
        num--;
        i++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите сколько будет чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Положительных чисел {Count(n)}");