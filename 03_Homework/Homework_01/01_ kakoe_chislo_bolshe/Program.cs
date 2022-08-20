/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее==");
Console.Write("Введите число X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    Console.Write($"Число X:{x} больше числа Y:{y} ");
}
else
{
    Console.Write($"Число Y:{y} больше числа X:{x} ");
}