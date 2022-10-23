/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

// метод для проверки числа сравнением
/* bool isPalindrome(int number)
{
    int save = number;
    Console.WriteLine($"{save}");

    int value;

    int rev = 0;

    while (save > 0)
    {
        value = save % 10;
        //Console.WriteLine($"{value}");
        rev = rev * 10 + value;
        //Console.WriteLine($"{rev}");
        save /= 10;
        //Console.WriteLine($"{save}");
    }

    if (rev == number)
    {
        Console.WriteLine($"{number} -> Да");
        return true;
    }
    else
    {
        Console.WriteLine($"{number} -> Нет");
        return false;
    }
}

Console.Write("Число палиндром?: ");
int num = Convert.ToInt32(Console.ReadLine());

isPalindrome(num); */

/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z1 - z2;

    double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
    return Math.Round(distance,2);
}

Console.WriteLine("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ответ: {Distance(x1, y1, z1, x2, y2, z2)}"); */


/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 */

/* void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        double result = Math.Pow(count, 3);
        Console.Write(result + " ");
        count++;

    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Table(number); */