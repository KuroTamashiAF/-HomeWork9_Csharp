// Найти сумму цифр числа
int SumDigitsNumber(int number)
{
    if (number != 0)
    {
        return number%10 + SumDigitsNumber(number/10);
    }
    else 
        return number;

}
Console.Write("Enter the number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int sum = SumDigitsNumber(Number);
Console.Write(sum);


