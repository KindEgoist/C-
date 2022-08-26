// Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n.


void Square(int number)
{
	int current = 1;
	while (current <= number)
	{
		Console.Write(current * current + " ");
    	current++;
	}
}
 Console.Write("Введите номер: ");
int num = Convert.ToInt32(Console.ReadLine());
Square (num);

