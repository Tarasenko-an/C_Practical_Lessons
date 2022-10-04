// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Input number m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number n: ");
int numN = Convert.ToInt32(Console.ReadLine());



System.Console.WriteLine($"Ackerman function A(m, n) \n A({numM}, {numN}) = {Ackerman(numN, numM)}");
int Ackerman(int numN, int numM)
{
    if (numN == 0) return numM + 1;
    if (numN != 0 && numM == 0) return Ackerman(numN - 1, 1);
    if (numN > 0 && numM > 0) return Ackerman(numN - 1, Ackerman(numN, numM - 1));
    return Ackerman(numN,numM);
}
