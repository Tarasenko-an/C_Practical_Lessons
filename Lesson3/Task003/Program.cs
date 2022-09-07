// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Ввод числа
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());


//Функция нахождения последовательности кубов чисел от 1 до number
void GetCubeNumber(int num)
{
    int count = 1;
    while (count <= Math.Abs(num))
    {
        Console.WriteLine($"The cube of the number {count} is {Math.Pow(count,3)}");
        count++;
    }
}

//Вызов функции
GetCubeNumber(number);