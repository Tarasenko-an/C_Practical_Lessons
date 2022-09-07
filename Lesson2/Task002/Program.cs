// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//Ввод числа
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

//Находим число порядков
int digitcount(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num/10;
        count++;
    }
    return count;
}

//Находим нужную цифру в числе
int dig3th(int num, int count, int ndig)
{
    while (count > ndig)
    {
        num = num/10;
        count--;
    }
    int digit = num % 10;
    return digit;
}
//Проверяем, что число 3х-значное
if (number > 99)
{
    Console.WriteLine(dig3th(number, digitcount(number), 3));
}
else
{
    Console.WriteLine($"The number {number} does not contain a 3rd digit!");
}
