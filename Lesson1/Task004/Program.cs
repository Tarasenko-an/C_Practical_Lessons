//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Ввод числа
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 2;

//Если есть хоть одно число для вывода
if (num > 1)
{
    Console.Write("Четные числа: ");
    while (count < num + 1)
    {
        Console.Write($"{count} ");
        count+=2;
    }
}
//Если нет чисел для вывода
else 
{
    Console.Write("Нет четных чисел в диапазоне");
}
