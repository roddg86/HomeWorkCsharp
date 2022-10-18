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
Console.Write("Найдем третью цифру, введите число: ");
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

// Вывести третью цифру
int Chek(int number)
{
    int newNum = HowManyDigits(number);
    if (newNum > 2)
    {
        while (newNum > 3)
        {
            number = number / 10;
            newNum--;
        }
        Console.WriteLine($"третья цифра: "); 
        return number % 10;
    }
    else
    {
        Console.WriteLine($"цифр в числе: "); 
        return newNum;
    }
}

Console.WriteLine(Chek(number));
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
bool CheckDay(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("да");
        return true;
    }
    else
    {
        Console.WriteLine("нет");
        return false;
    }
}
CheckDay(number);
*/