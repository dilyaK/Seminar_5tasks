// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечетных позициях.


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 9999);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void SumOddDigits(int[] array)
{
    double SumOddDigits = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) SumOddDigits += array[i];
    }
    Console.Write($"The sum of odd numbers: {SumOddDigits}");
}

Console.Write("Enter the number of elements: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
FillArray(array);
PrintArray(array);
SumOddDigits(array);
