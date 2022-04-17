// Написать программу вычисления функции Аккермана
int FunctionOfAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FunctionOfAkkerman(m - 1, n = 1);
    }
    else if (m > 0 && n > 0)
    {
        return FunctionOfAkkerman(m - 1, FunctionOfAkkerman(m, n - 1));
    }
    return -1;
}
Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(FunctionOfAkkerman(m, n));

