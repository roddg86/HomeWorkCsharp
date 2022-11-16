/* Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.) */

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
}
 */
/* // метод разворачивает массив
void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i]; // во временную переменную записали текущий элемент
        array[i] = array[j]; // в текущий элемент его симметричный правый элемент
        array[j] = temp; // поменяли местами 
    }
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
 */

/* Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: a и b.

Фибоначчи = это каждое новое число генерируется на основании суммы 
двух предыдущих чисел
 */

/* int[] Fib(int size, int a, int b)

{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;

    for (int i = 2; i < size; i++)
        array[i] = array[i - 1] + array[i - 2];
    return array;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
//ShowArray(myArray);
ShowArray(Fib(n, min, max)); */

/* 
Напишите программу, которая будет создавать копию заданного массива
с помощью поэлементного копирования. */

/* int[] Copy(int[] array)
{
    int[] copyArary = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyArary[i] = array[i];
    return copyArary;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
ShowArray(Copy(myArray));
 */

/* 
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины. */

bool Triangle(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(n, min, max));
