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
    revers = revers + temp  ;
    }
    
    if (revers == save) Console.WriteLine ("yes");
    else Console.WriteLine("no");
}

Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());
Palindrom(num);