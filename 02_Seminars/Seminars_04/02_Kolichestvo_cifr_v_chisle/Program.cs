// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Num(int num)
{   
    int size = 0;
    while (num > 0)
    {
        num = num / 10;
        size++;
    }
    return size;
}

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количиство цифр в числе {a} равно {Num(a)}");

