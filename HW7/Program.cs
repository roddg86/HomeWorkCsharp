/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

/* // метод генерирует двумерный массив заполненный случайнми вещественными числами
double[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1) + +new Random().NextDouble(); ;

    return array;
}

// метод выводит двумерный массив на экран
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 1) + "  ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2Array(m, n, min, max);
Show2dArray(myArray); */

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> числа с такими индексами в массиве нет */

/* // метод генерирует двумерный массив заполненный случайнми числами
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

// метод ищет элемент в массиве по заданной позиции
bool SearchElement(int[,] array, int rows, int columns)
{
    int current = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == rows - 1 && j == columns - 1)
                current = array[i, j];

    if (rows < 0 | rows > array.GetLength(0) | columns < 0 | columns > array.GetLength(1))
    {
        Console.WriteLine($"{rows}{columns} -> there are no numbers with such indices in the array");
        return false;
    }
    else
    {
        Console.WriteLine($"The value of the selected item: {current}");
        return true;
    }
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

Console.Write("Enter element string: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter element column: ");
int columns = Convert.ToInt32(Console.ReadLine());

SearchElement(myArray, rows, columns);
 */
 
/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

