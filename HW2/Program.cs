/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    int ed = number % 100;
    int result = ed / 10;

    return result;
}

int newNum = SecondDigit(number);

Console.WriteLine($"New version of {number} is {newNum}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// метод подсчитыает количество цифр в числе
int HowManyDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        number = number / 10;
        result++;
    }

    return result;
}

// метод выводит третью цифру 3 значного числа
int ThirdDigit3(int number)
{
    int result = number % 10;

    return result;
}

// метод выводит третью цифру 5 значного числа
int ThirdDigit5(int number)
{
    int result = (number/100)%10;

    return result;
}

int newNum = HowManyDigits(number);

// Проерим есть ли третья цифра и выведем ее 
void Chek(int number)
{
    if(newNum < 3)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else if (newNum == 3)
    {
        Console.WriteLine(ThirdDigit3(number));
    }
    else
    {
        Console.WriteLine(ThirdDigit5(number));
    }
}

Chek(number);
*/


