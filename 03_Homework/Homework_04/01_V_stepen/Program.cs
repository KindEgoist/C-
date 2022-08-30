/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int AB(int a1, int b1)
{
    int step = 1;
    for (int i = 0; i < b1; i++)
    {
        step = step * a1;
    }
    return step;
}

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(циклом)==");
Console.SetCursorPosition(0, 10);
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число степени: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} = {AB(a,b)}");