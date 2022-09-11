// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Метод возведения числа в натуральную степень
int GetPow(int num, int pow)
{
    int result = 1;
    if (pow >= 0)
    {
        for(int i = 0; i < pow; i++)
        {
            result *= num;
        }
        return result;
    }
    else
    {
        return -1;
    }
}

//Метод ввода числа 
int InputNum(string mess)
{
    System.Console.WriteLine(mess);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

//Вводим числа
int num1 = InputNum("Input number 1: ");
int num2 = InputNum("Input number 2: ");

//Возводим в степень
int pow = GetPow(num1, num2);

//Вывод результата
if (pow != -1)
{
    System.Console.WriteLine($"The {num1} to the power of {num2} is {pow}");
}
else
{
    System.Console.WriteLine($"{num2} is a negative number, the degree is not calculated.");
}