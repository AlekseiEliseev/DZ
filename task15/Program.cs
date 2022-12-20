// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
    Console.Write("Понедельник - нет");
}
else if (a == 2)
{
    Console.Write("Вторник - нет");
}
else if (a == 3)
{
    Console.Write("Среда - нет");
}
else if (a == 4)
{
    Console.Write("Четверг - нет");
}
else if (a == 5)
{
    Console.Write("Пятница - нет");
}
else if (a == 6)
{
    Console.Write("Суббота - да");
}
else if (a == 7)
{
    Console.Write("Воскресенье - да");
}
else
{
    Console.Write("Ошбика - такого дня недели нет");
}
