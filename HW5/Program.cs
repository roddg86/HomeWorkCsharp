/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

/* // метод генерирует массив случайных чисел
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

// метод выводит массив на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
} */

/* int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    Console.WriteLine(count);
    return count;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
CountEvenNumber(myArray); */

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

/* int SumElementsOddPositions(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0) sumOdd += array[i];
    Console.WriteLine(sumOdd);
    return sumOdd;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
SumElementsOddPositions(myArray); */

/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

/* // метод генерирует массив случайных вещественных чисел
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }

    return array;
}

// метод выводит массив на экран
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");

    Console.WriteLine();
}

// метод находит разницу между максимальным и минимальным элементов массива
// в диапазоне отрицательных и положительных значений 
double DifferenceMaxMin(double[] array)
{
    var minV = array[0];
    var maxV = minV;
    double diff = 0;

    for (int i = 0; i < array.Length; i++)

        if (array[i] < minV) minV = array[i];
        else if (array[i] > maxV) maxV = array[i];

    Console.WriteLine();
    Console.WriteLine($"Maximum element:  {Math.Round(maxV, 2)}");
    Console.WriteLine($"Minimum element:  {Math.Round(minV, 2)}");

    if (maxV > 0 && minV < 0) diff = minV + maxV;
    else diff = minV - maxV;

    Console.WriteLine();
    Console.WriteLine($"Difference: {Math.Abs(Math.Round(diff, 2))}");

    return diff;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
DifferenceMaxMin(myArray);
 */