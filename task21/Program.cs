// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());


double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2)), 2);
Console.WriteLine(distance);