/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.==");
int TwoCif(int num)
{
    int pervaya = num % 100;
    int vtoraya = pervaya / 10;

    return vtoraya;
}

Console.SetCursorPosition(0, 10);
Console.Write("Введите трехзначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
int resul = TwoCif(chislo);

Console.WriteLine($"Вторая цифра {resul} от {chislo}");







