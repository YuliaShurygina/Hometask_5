// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Write($" Введите коэффициент k1  ");
int k1 = int.Parse(Console.ReadLine()??"0");
Console.Write($" Введите коэффициент b1  ");
int b1 = int.Parse(Console.ReadLine()??"0");
Console.Write($" Введите коэффициент k2  ");
int k2 = int.Parse(Console.ReadLine()??"0");
Console.Write($" Введите коэффициент b2  ");
int b2 = int.Parse(Console.ReadLine()??"0");

if (b1 < 0)  
    Console.WriteLine($"Уравнение первой прямой y = {k1}*x {b1}");
else
    Console.WriteLine($"Уравнение первой прямой y = {k1}*x + {b1}");
if (b2 < 0)
    Console.WriteLine($"Уравнение второй прямой y = {k2}*x {b2}");
else 
    Console.WriteLine($"Уравнение второй прямой y = {k2}*x + {b2}");

if (k1 == k2 && b1 == b2)
    Console.WriteLine(" Прямые совпадают ");
  

else if (k1 == k2)
    Console.WriteLine(" Точки пересечения нет ");
else
{
    double x = Math.Round((Convert.ToDouble(b2)-Convert.ToDouble(b1))/(Convert.ToDouble(k1)-Convert.ToDouble(k2)), 2);
    double y = Math.Round((Convert.ToDouble(k1)*x + Convert.ToDouble(b1)),2);
    Console.WriteLine($"Точка пересечения прямых ({x} ; {y})");
}    

