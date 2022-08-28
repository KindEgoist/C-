/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход число и проверяет, является ли оно палиндромом..==");
void  Palindrom (long number)
{
    long save = number;
    long revers = 0;
    long temp = 0;
    while (number > 0)
    {
        temp = number % 10;
        number = number / 10;
        revers = revers * 10;
        revers = revers + temp;
    }
    
    if (revers == save) 
    {
        Console.WriteLine ($"Число {save} палиндром");
    }
    else 
    {
        Console.WriteLine ($"Число {save} не палиндром");
    }
}

Console.SetCursorPosition(0, 10);
Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());
Palindrom(num);