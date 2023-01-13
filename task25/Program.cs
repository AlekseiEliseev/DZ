// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Comp(int a, int b)
{
int result = 1;
for(int i = 1; i <= b; i++)
{
    result = result * a;
}
return result;
}

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = Comp(A, B);
Console.WriteLine(result);