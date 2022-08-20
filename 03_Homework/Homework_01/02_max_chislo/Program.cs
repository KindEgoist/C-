/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел==");
Console.WriteLine("Введите три числа ");
Console.Write("Первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.Write($"Максимальное число {max} "); 
 
