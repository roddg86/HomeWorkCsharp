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

// Решение 2
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

void ChekNumber(string numberText)
{
    if (numberText.Length > 2)
    {
        Console.WriteLine($"{number} -> " + numberText[2]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}

ChekNumber(numberText);
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*
Console.Write("Введите номер дня, является ли день выходным: ");

int number = Convert.ToInt32(Console.ReadLine());

void CheckDay(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

CheckDay(number);
*/