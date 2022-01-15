// Написать программу масштабирования фигуры (я считала для прямоугольника)
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
 
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
        if (j % 2 == 0) 
            Console.Write($"( {array[i,j]} , ");
        else
            Console.Write($"{array[i,j]} )  "); 
    }
}
double[,] Scale(double[,] arr, double k)
{
    double [,] NewArray = new double[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           NewArray[i,j] = arr[i,j] * k;
       }
    }
    return NewArray;
}

Console.Write("Введите x0 = ");
double x0 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите y0 = ");
double y0 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите x1 = ");
double x1 = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите y1 = ");
double y1 = int.Parse(Console.ReadLine()??"0");
double[,] PointArray = new double[ 4, 2 ];
PointArray[0,0] = x0;
PointArray[0,1] = y0;
PointArray[1,0] = x1;
PointArray[1,1] = y0;
PointArray[2,0] = x1;
PointArray[2,1] = y1;
PointArray[3,0] = x0;
PointArray[3,1] = y1;
Console.WriteLine($"Координаты вершин исходной фигуры: ");
PrintArray(PointArray);
Console.WriteLine();
Console.Write("Введите коэффициент масштабирования k = ");
double coefficient = double.Parse(Console.ReadLine()??"0");
double[,] ScaledArray = Scale(PointArray, coefficient);
Console.WriteLine($"Координаты вершин  фигуры после масштабирования: ");
PrintArray(ScaledArray);


