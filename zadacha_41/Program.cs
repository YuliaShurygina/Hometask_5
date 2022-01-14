//Выяснить являются ли три числа сторонами треугольника
Console.Write("Введите число #1  ");
int numberA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите число #2  ");
int numberB = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите число #3 ");
int numberC = int.Parse(Console.ReadLine()??"0");
if ((numberA + numberB > numberC) && (numberA + numberC > numberB) && (numberB + numberC > numberA))
     Console.WriteLine("да");
else Console.WriteLine("нет");

