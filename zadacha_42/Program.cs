// Определить сколько чисел больше 0 введено с клавиатуры
void FillArray( int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" Введите {i +1}е  число:  ");
        array[i] = int.Parse(Console.ReadLine()?? "0");
    }
}
void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} " );
    }
}
int PositiveNumbers(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
            count++;
    }
    return count;
}
Console.Write("Введите количество вводимых чисел  ");
int length = int.Parse(Console.ReadLine()??"0");
int[] SpecifiedArray = new int[length];
FillArray(SpecifiedArray);
Console.WriteLine();
PrintArray(SpecifiedArray);
Console.WriteLine();
int number = PositiveNumbers(SpecifiedArray);
Console.WriteLine($" Количество чисел больше нуля равно {number} ");