// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Ввод строки
Console.WriteLine("Enter string:");
string s = Convert.ToString(Console.ReadLine());

//Проверка строки на палиндром
bool CheckPalindrom (string s)
{        
    for (int i = 0,  j = s.Length - 1; i < j; i++, j--)
    {
        if (s[i] != s[j])
        {
             return false;
        }
    }
    return true;     
}

//Вызов метода проверки строки на палиндром
if (CheckPalindrom(s))
{
    Console.Write("String is palindrom");
}
else 
{
    Console.WriteLine("String is not palindrom");
}