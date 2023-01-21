// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

Console.WriteLine("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
FillArrayWithRandom(array);
Console.Write("Ваш массив: ");
Console.WriteLine(string.Join(", ", array));

int count = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Вы ввели чисел больше 0: {count}");

// Console.Write(string.Join(", ", array));
// Console.WriteLine($"-> {count}");