// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
int Fibonachi(int n)
{
    if (n == 1 || n == 2)
        return 1;

    else
        return Fibonachi(n - 1) + Fibonachi(n - 2);
}
Console.Write("Enter number N: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.Write(Fibonachi(i) + " ");
}

