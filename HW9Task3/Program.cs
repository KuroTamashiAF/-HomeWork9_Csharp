// Написать программу возведения числа А в целую стень B
int DegreeNumberA(int a, int degree)
{
    if (degree >= 1)
    {
        return a * DegreeNumberA(a, degree - 1);
    }
    return 1;
}
Console.Write("Enter the number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the degree: ");
int Degree = Convert.ToInt32(Console.ReadLine());
Console.Write(DegreeNumberA(A, Degree));


