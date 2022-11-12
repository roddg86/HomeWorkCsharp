int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number /100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 10000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");