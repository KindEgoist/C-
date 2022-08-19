// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите число X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int kvadrat = y * y;
if (x == kvadrat)
{
    Console.WriteLine($"X {x} является квадратом Y {y} ");
}
else
{
    Console.WriteLine($"X {x} не является квадратом Y {y} ");
}

