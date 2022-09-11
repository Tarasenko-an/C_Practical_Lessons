// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Метод ввода числа 
int InputNum(string mess)
{
    System.Console.WriteLine(mess);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

//Метод вычисления суммы чисел
int GetSumma(int num)
{
    int summa = 0;
    for(int i = 0; num > 0; i++)
    {
        summa += num % 10;
        num /= 10;
    }
    return summa;
}

int number = InputNum("Input number: ");
int summa = GetSumma(number);
System.Console.WriteLine($"Summa of digits: {summa}");