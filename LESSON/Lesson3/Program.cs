/* void ShowQuart(int quartNum)
{
    if (quartNum >= 1 && quartNum <= 4)
    {
        if(quartNum == 1) Console.WriteLine("x > 0 and y > 0");
        else if (quartNum == 2) Console.WriteLine("x < 0 and y > 0");
        else if (quartNum == 3) Console.WriteLine("x < 0 and y < 0");
        else Console.WriteLine("x > 0 and y < 0");
    }
    else
        Console.WriteLine("Wrong number!");
}

Console.Write("Input a number of quart: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowQuart(num);
 */

/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
 */

/* int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Input x: ");
Console.WriteLine("Input y: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ответ: {Quarter(x, y)}");
 */

/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
 */

/* double Point(int x1, int y1, int x2, int y2)
{
    int x = x1 - x2;
    int y = y1 - y2;

    double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
    return distance;
}

Console.WriteLine("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ответ: {Point(x1, y1, x2, y2)}"); */

/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
 */

/* void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        double result = Math.Pow(count, 2);
        Console.Write(result + " ");
        count++;

    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Table(number); */