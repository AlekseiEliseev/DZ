// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
int sum = 0;
for(int i = 1; i <= number; i++)
{
    sum += number % 10;  // sum = sum + (number %10)
    number /=10; // number = number / 10
}
return sum;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = Sum(A);
Console.WriteLine(sum);