/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива. */

// метод генерирует массив случайных чисел
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
}
/*
// метод находит сумму отрицательных элементов массива
int GetNegativeSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sum += array[i];

    return sum;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int negativeSum = GetNegativeSum(myArray);
Console.WriteLine("Sum of negative elements is " + negativeSum); */

/*Задать массив, написать программу которая определит присутсвует ли заданное число в массиве */

// Массив число bool

/* bool FindNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}
int[] array = CreateRandomArray(5, 1, 99);
ShowArray(array);
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNum(array, num));
 */


/* Задайте одномерный массив из m случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [a,b]. */

/* int CountArr(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
            count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, 1, 9);
ShowArray(array);
Console.WriteLine(CountArr(array, min, max));
 */

/* Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот. */

// не возвращаем массив потому что нам нужно его поменять
// а так как массив это ссыллочный тип сделаем метод void

void SetOppositeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
}

Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
SetOppositeArray(myArray);
ShowArray(myArray);
