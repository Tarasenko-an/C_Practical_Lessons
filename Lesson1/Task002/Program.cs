//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Ввод числа A
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

//Ввод числа B
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

//Ввод числа С
Console.Write("Введите число С: ");
int numС = Convert.ToInt32(Console.ReadLine());

//Определяем максимальное число
int max = Math.Max(numA, Math.Max(numB, numС));

Console.WriteLine($"Максимальное число = {max}");