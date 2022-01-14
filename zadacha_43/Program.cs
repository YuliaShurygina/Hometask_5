// Написать программу преобразования десятичного числа в двоичное

int[] FillArray(int length, int number)
{
    int num = number;
    int[] array = new int[length];
    for (int i = length - 1; i >= 0; i--)
    {
        if (num >= 2)
        {
            array[i] = num % 2;
            num = num/2;
        }     
        else
            array[i] = 1;
            
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите число  ");
int number = int.Parse(Console.ReadLine()??"0");
double len = Math.Log2(number);
int length = 0;
if (len * 10 % 10 < 5)
    length = Convert.ToInt32 (len + 1);
else  length = Convert.ToInt32 (len);
Console.WriteLine(length);
int[] binary = FillArray(length, number);
PrintArray(binary);
