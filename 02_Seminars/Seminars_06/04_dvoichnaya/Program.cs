// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string Dvoichnaya(int num)
{
    string rezultat = string.Empty;
    while (num > 0)
    {
        int n = num % 2;
        rezultat = n + rezultat;
        num = num / 2;
    }
    return rezultat;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string finish = Dvoichnaya(n);
Console.WriteLine($"Число {n} в двоичной {finish}");