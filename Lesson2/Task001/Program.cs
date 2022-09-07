// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Ввод числа
Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

//Проверка на 3х значное число
if (number > 99 && number <1000 )
{
    Console.WriteLine(dig2(number));
}
else
{
    Console.WriteLine($"Number {number} is not a tree-digit!");
}
//Нахождение 2й цифры числа
int dig2(int num)
{
    int digit = num/10 % 10;
    return digit;
}
