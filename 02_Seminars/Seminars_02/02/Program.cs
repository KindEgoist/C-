// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int DeleteSecond(int number)
{
    int first_number = number / 100; 
    int third_number = number % 10; 
    int result = first_number * 10 + third_number;
    
    return result;
}

int randNumber = new Random().Next(100,1000);
int completeNumber = DeleteSecond(randNumber);

Console.WriteLine($"Случайное число {randNumber} и результат с удаленной второй цифрой {completeNumber}");