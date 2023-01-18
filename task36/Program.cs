// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

Console.WriteLine("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int sum = 0;

for(int i = 1; i < array.Length; i=i+2)
{
    sum = sum + array [i];
}
Console.WriteLine("Сумма элементов стоящих на нечетных позициях: " + sum);