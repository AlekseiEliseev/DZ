// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;


while (a > 1000)
{
    a = a / 10;
    count ++;
}
if (a >= 100)
{
    a = a % 10;
Console.WriteLine(a);
}
else 
    Console.WriteLine("Третьей цифры нет");