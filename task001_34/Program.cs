// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Enter the number of elements in array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

void Count(int[] arr)
{
    int check = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) check++;
    }
    Console.Write($"The quantity of even elements in array: {check}");
}


FillArray(array);
PrintArray(array);
Count(array);
