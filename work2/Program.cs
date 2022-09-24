// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите номер строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5, 5];
FillRandomArray(array);
GetElementValue(array);
PrintArray(array);

void GetElementValue(int[,] array)
{
    if (rows > array.GetLength(0) || columns > array.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {array[rows - 1, columns - 1]}");
    }
}

void FillRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }

}