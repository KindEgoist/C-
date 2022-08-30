/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Sum(int num)
{
    int sum = 0;
    int temp = 0;
    while (num > 0)
    {
        temp = num % 10;
        num = num / 10;
        sum = sum + temp;
    }
    return sum;
}
Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход число и выдаёт сумму цифр в числе.==");
Console.SetCursorPosition(0, 10);
Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр {Sum(chislo)} числа {chislo}");
