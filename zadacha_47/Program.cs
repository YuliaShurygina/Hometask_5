// Написать программу копирования массива (Массив заполнила случайными числами)
int [] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}
void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Array[i]} ");
    }
}
int[] Copy(int[] someArray)
{
    int[] arr = new int[someArray.Length];
    for (int i = 0; i < someArray.Length; i++)
    {
        arr[i] = someArray[i];
    }
    return arr;
}
Console.Write("Введите длину массива ");
int n = int.Parse(Console.ReadLine()??"0");
int[] NewArray = FillArray(n);
Console.WriteLine();
PrintArray(NewArray); 
Console.WriteLine();
Console.WriteLine("Скопированный массив: ");
int[] CopiedArray = Copy(NewArray);
PrintArray(CopiedArray);
