// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumOfDigital(int n)
{
    if(n > 0) return SumOfDigital(n / 10) + n % 10;
    else return 0;
}

Console.Write(SumOfDigital(5364));