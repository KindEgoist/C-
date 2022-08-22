// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/* 1423 % 10 = 3          1423 / 10 = 142
   1423 % 100 = 23        1423 / 100 = 14
   1423 % 1000 = 423      1423 / 1000 = 143
*/


int FindBiggerDigit(int number)
{
    int ed = number % 10; //единицы     
    int dec = number / 10; //десятки
    int max;
    if(ed > dec) max = ed;
    else max= dec;
    return max;
}

int randNumber = new Random().Next(10,100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Число {randNumber} и ее наибольшая цифра {biggerDigit}"); 