/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    int ed = number % 100;
    int result = ed / 10;

    return result;
}

int newNum = SecondDigit(number);

Console.WriteLine($"New version of {number} is {newNum}");