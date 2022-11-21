﻿/* Задайте двумерный массив. 
Напишите программу, которая поменяет местами 
первую и последнюю строку массива. */

// метод генерирует двумерный массив заполненный случайнми числами
int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

// метод выводит двумерный массив на экран
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) &&
        row2 >= 0 && row2 < array.GetLength(0) &&
        row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    else Console.WriteLine("Impossible to change!");
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = CreateRandom2Array(m, n, min, max);
Show2dArray(myArray);

Console.Write("Input a number of the first row to change: ");
int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input a number of the first row to change: ");
int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);


