Console.Write("Imput number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int Maximum = number1;
 
 if(Maximum>number2)
 {
    Console.WriteLine($"Maximum number is {number1}");
 }
else
{
    Maximum = number2;
}
if(Maximum>number3)
{
    Console.WriteLine($"Maximum number is {number2}");
}
else
{
    Maximum = number3;
}
Console.WriteLine($"Maximum number is {Maximum}");