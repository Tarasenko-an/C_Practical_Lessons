//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Ввод числа A
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

//Ввод числа B
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

//Если числа равны
if (numA == numB)
{
    Console.WriteLine($"Число A = {numA} равно Числу B = {numB}");
    Console.WriteLine($"max = {numA}");
}

//Если A > B
else if (numA > numB)
{
    Console.WriteLine($"Число A = {numA} больше Числа B = {numB}");
    Console.WriteLine($"max = {numA}");
}

//Если A < B
else if (numA < numB)
{
    Console.WriteLine($"Число A = {numA} меньше Числа B = {numB}");
    Console.WriteLine($"max = {numB}");
}