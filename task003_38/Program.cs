//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Enter the array length : ");
int a = Convert.ToInt32(Console.ReadLine());
void FillArray(double[] array)
{
    Console.WriteLine("Enter  the numbers of an array: ");
    for (int i = 0; i < array.Length; i++) array[i] = Convert.ToDouble(Console.ReadLine());
}

void PrintArray(double[] array)
{
    Console.Write("Array numbers: ");
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    Console.WriteLine($"The max number: {max}");
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    Console.WriteLine($"The minimal number: {min}");
    return min;
}

Double[] array = new double[a];
FillArray(array);
PrintArray(array);
Console.WriteLine("Difference between max and min: {0}", Max(array) - Min(array));;
