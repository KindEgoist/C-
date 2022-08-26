//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void FindInterval(int number)
{
	if (number == 1) Console.WriteLine ($"Диапазон возможных координат в четверти {number}: x>0 and y>0");
	if (number == 2) Console.WriteLine ($"Диапазон возможных координат в четверти {number}: x<0 and y>0");
	if (number == 3) Console.WriteLine ($"Диапазон возможных координат в четверти {number}: x<0 and y<0");
	if (number == 4) Console.WriteLine ($"Диапазон возможных координат в четверти {number}: x>0 and y<0");
	if (number > 4 || number < 1) Console.WriteLine ($"Четверти с таким номером не существует");
	
}
Console.Write("Введите номер чертвити: ");
int num = Convert.ToInt32(Console.ReadLine());
FindInterval(num);

