// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Faktorial(int num)
{
    int f = 1;
    for(int i = 1; i <= num; i++)
        f = f * i;
    return f;
}

Console.Write("Введите число: ");
int fac = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Факториал числа {fac} равен {Faktorial(fac)}");