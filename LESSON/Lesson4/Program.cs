/* 
Напишите программу которая на вход принимает число и выдет сумму чисел до этого самого числа
 */

/* int FindSum(int number)
{
    int sum = 0;

    for (int current = 1; current <= number; current++)
    {
        sum += current;
    }
    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of number from 1 to {a} is {FindSum(a)}");

/* 

Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

 */

/* int CountDigit(int number)
{
    int num = Math.Abs(number);
    int count = 0;

    if (num == 0)
    {
        count = 1;
    }

    while (number != 0)
    {
        number /= 10;
        count++;
    }

    return count;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number of digits in a number {a} is {CountDigit(a)}"); */


/* 

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

 */

/* int Fact(int number)
{
    int product = 1;

    for (int current = 1; current <= number; current++)
    {
        product *= current;
    }
    return product;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Factorial of {a} is {Fact(a)}"); */

/* 

Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

 */

/* // метод генерации массива случайных чисел
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // выделяем память под массив

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
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
Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray); */
