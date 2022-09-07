// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Ввод числа
Console.Write("Enter number day of week(1-7): ");
int number = Convert.ToInt32(Console.ReadLine());

void dayweek(int num)
{
    switch(num)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
    }
}

if (number > 0 && number <8) 
{
    dayweek(number);
}
else
{
    Console.WriteLine($"Incorrect input {number} not the day of the week!");
}