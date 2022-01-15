// Показать числа Фибоначчи

double [] FillArray(int length)
{
    double[] array = new double[length];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}
void PrintArray(double [] Array)
{
    for (int i = 0; i < Array.Length; i++)
       Console.Write($" {Array[i]} ");
}

Console.Write("Количество чисел Фибоначчи N = ");
int N = int.Parse(Console.ReadLine()??"0");
double [] Fibonacci = FillArray(N);
PrintArray(Fibonacci);