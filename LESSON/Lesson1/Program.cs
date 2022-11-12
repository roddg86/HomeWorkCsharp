// базовые типы данных
/* int a = 31;
double b = -12.45;
string c = "world";
char d = '#';
bool e = true;

Console.WriteLine("Hello! " + a + " and it is good!");
Console.WriteLine($"Hello! {b} and it is good!"); */

//Задача 1. Определить является ли первое число квадратом второго

/*
Console.Write("Input a ferst number: ");
int n1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2  = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (quad2 == n1)
{
    Console.WriteLine($"Number {n1} is square of {n2}");
}
else
{
    Console.WriteLine($"Number {n1} is not a square of {n2}");
}
*/

//Задача 2. 
/*
Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/

/*
4123 % 10 -> 3
4123 % 100 -> 23
4123 % 1000 -> 123
4123 % 10000 -> 4123

4123 / 10 -> 412
4123 / 100 -> 41
4123 / 1000 -> 4
*/

// Задача 3. Принимаем трехначное число на выходе показываем последняя цифра
/*
Console.Write("Input three digit integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
Console.WriteLine($"Last digit of {number} is {result}");
*/


