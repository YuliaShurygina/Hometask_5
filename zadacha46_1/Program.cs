// Написать программу масштабирования фигуры 
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

int CountBlancks(string str) 
{     
    int count=0;    
    for(int i=0;i<str.Length;i++)       
        if(str[i]==' ')        
            count++;    
            return count;
}
string[] CoordinatesArray(string str, int blanks)
{
    string [] array = new string[blanks +  1];
    int stringNumber = 0; 
    for(int i=0;i<str.Length;i++)
    {
        string point=""; 
        while(i<str.Length && str[i]!=' ')   
        {     
            if(str[i]=='(' || str[i]==')' || str[i]==',')   
            {  
                 i++; 
                 continue;
            }
            point+=str[i];
            i++;
        }
        array [stringNumber] = point;
        stringNumber++;
        
    }
    return array;      
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int[,] ParseInts(string[] Array)
{
    int[,]matrix = new int[Array.Length,2];
    for (int i = 0; i<Array.Length;i++)
    {
        string element = Array[i];

        char[] first = new char[2];
        for (int j = 0; j < element.Length;j++)
        {
            first[j] = element[j];
            matrix[i,j] = Convert.ToInt32(new string(first[j], 1));
            
        }
    }
    return matrix;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] Scale(int[,] arr, int k)
{
    int [,] NewArray = new int[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           NewArray[i,j] = arr[i,j] * k;
       }
    }
    return NewArray;
}
 
void PrintArrayCoordinates(int[,] array)
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
string str = "(0,0) (2,0) (2,2) (0,2)";
//var str = Console.ReadLine() ?? "0";
Console.WriteLine(str);
int blanks = CountBlancks(str);
Console.WriteLine(blanks);
string[] coordinates = CoordinatesArray(str, blanks);
PrintArray(coordinates);
Console.WriteLine();
int[,] coordinatesMatrix = ParseInts(coordinates);
PrintMatrix(coordinatesMatrix);
Console.Write("Введите коэффициент масштабирования k = ");
int coefficient = int.Parse(Console.ReadLine()??"0");
int[,] scaledMatrix = Scale(coordinatesMatrix, coefficient);
PrintArrayCoordinates(scaledMatrix);


