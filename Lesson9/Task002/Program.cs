// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
if ((numN >= 0) && (numM >= 0) && (numN >= numM))
{
    Console.WriteLine($"Sum of natural numbers from M to N: {SumNaturalNumber(numM, numN)}");
}
else
{
    Console.WriteLine($"M = {numM}, N = {numN} Calculation is impossible"); 
}

int SumNaturalNumber(int num1, int num2)
{
    if (num2 == num1)
    {
        return num1;
    }
    
    return (num1 + SumNaturalNumber(num1 + 1, num2));
}
