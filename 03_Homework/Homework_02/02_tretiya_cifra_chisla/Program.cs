/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.==");
int KolichestvoSimvolov(int num)
{   int n = 100;
    int current = 2;
    while (num / n > 1)
    {    n = n * 10;
        current++;
    }
    return current;
}

int Razryad(int num2)
{
    int x = 10;
        while (num2 - 1 > 0 )
    {
        x = x * 10;
        num2--;
    }
    
    return x;
} 
Console.SetCursorPosition(0, 10);
Console.Write("Введите число: ");
int vvod = Convert.ToInt32(Console.ReadLine());
int chislo = KolichestvoSimvolov(vvod);
//Console.WriteLine(chislo);
int finishnaya = Razryad(chislo);
//Console.WriteLine(proc);

int ostatok = finishnaya / 100;
int desyatki = finishnaya / 1000;
int fin= 0;
int fininsh = 0;
if (vvod / 100 == 0)
{   
    Console.WriteLine($"Третьей цифры нет у заданного числа {vvod}");
}
else
{
    fin = vvod % ostatok;
    fininsh = fin / desyatki;
    Console.WriteLine($"Третья цифра {fininsh} заданного числа {vvod}");
}