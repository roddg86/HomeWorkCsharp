/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

/* int Exponentiation(int A, int B)
{
    int exp = 1;

    for (int i = 1; i <= B; i++)
    {
        exp *= A;
    }
    return exp;
}

Console.Write("Input a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} to the extent {b} is {Exponentiation(a, b)}"); */


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

/* int SumDigit(int number)
{
    int result = 0;

    while (number != 0)
    {
        result += number % 10;
        number /= 10;
    }

    return result;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the digits in a number {a} is {SumDigit(a)}"); */

/* Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

метод генерации массива сделать исходя из данных которые ввел пользователь, чтобы пользоваель заполнил массив

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

/* // метод генерации массива случайных чисел
int[] CreateArray(int size)
{

    Console.WriteLine("Enter array elements:");

    int[] array = new int[size]; // выделяем память под массив

    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

//  метод вывода массива на экран
void ShowArray(int[] array)
{

    Console.Write("Array is: ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" :) \n ");
}

Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(n);
ShowArray(myArray); */