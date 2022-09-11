using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)" //возьмите текст
                .Replace("(", "") // замените в нем скобочки
                .Replace(")", "")
                ;
Console.WriteLine(text);


var data = text.Split(" ") // возьми текст и разбей (разделитель пробел)
                .Select(item => item.Split(',')) // сделай выборку item пробел в запитую
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))//сделать выборку из текущего массива. Берем из массива под индексом 0 элеент и конвертируем в число, так же и для второго
                .Where(e => e.x % 2 == 0) //проверка условия  дайте такие пары   что перваяя координата четная                                   
                .Select(point => (point.x * 10, point.y))//из предыдущего сделать первые координаты на 10 больше
                .ToArray();//привращение в массив

for (int i = 0; i < data.Length; i++)//вывод
{
    Console.WriteLine(data[i]);
}