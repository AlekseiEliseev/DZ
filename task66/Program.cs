// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int a, int b)
{
    if(a > b)
    {
        return 0;
    }
    int sum = 0;
    sum = a + Sum(a+1, b);
    return sum;
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = Sum(m, n);
Console.WriteLine(sum);