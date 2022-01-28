// // Написать программу масштабирования фигуры (я считала для прямоугольника)
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
int[] ParseInts(string str)
 {     
    int[] coordinates = new int[2];    
    string first="";   
    int i=0;   
    while(str[i]!=',')  
    {      
        first+=str[i];     
        i++;   
    } 
    coordinates[0] = int.Parse(first);   
    i++;     
    string second = "";    
    for(;i<str.Length;i++)        
        second+=str[i];   
    coordinates[1] = int.Parse(second); 
    return coordinates; 
}

var str = Console.ReadLine() ?? "0";
int blanks = CountBlancks(str);
Console.WriteLine(blanks);
var strings = new string[blanks+1]; 
int stringNumber = 0; 
for(int i=0;i<str.Length;i++) 
{     
    string point="";    
    while(i<str.Length && str[i]!=' ')   
       {     
            if(str[i]=='(' || str[i]==')')   
            {  
                 i++; 
                 continue;
            }
            point+=str[i];
            i++;
       }
       strings[stringNumber] = point;
       Console.WriteLine(strings[stringNumber]);
       stringNumber++;
    
}
Console.Write("Введите коэффициент масштабирования k = ");
int coefficient = int.Parse(Console.ReadLine()??"0");
for(int i=0;i<strings.Length;i++)
{   
    int[] coordinates = ParseInts(strings[i]);  
   // coordinates[i] = coordinates[i]*coefficient;
    Console.WriteLine($" {coordinates[0]} {coordinates[1]}");
}

