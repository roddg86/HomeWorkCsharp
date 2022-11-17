/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

/* int NumbersGreater(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Enter the number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) count++;
    }
    Console.WriteLine($"Numbers greater than zero here: {count}");
    return count;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

NumbersGreater(n); */

/* Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* void Intersection(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Direct match");
    else if (k1 == k2) Console.WriteLine("Straight lines are parallel");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($"Intersection point: ({x};{y})");
    }
}

Console.Write("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Intersection(b1, k1, b2, k2); */