// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int SizeArray = 0;
Console.WriteLine("Input size array: ");
SizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers: ");

int[] array = new int[SizeArray];
FillArray(array);
ShowArray(array);
Console.WriteLine($"Number of positive numbers in the array: {PositiveNum(array)}");

//Вывод массива на экран
void ShowArray(int[] arr)
{
    Console.Write($"Array: [{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]\n");
}

//Заполнение массива с клавиатуры
void FillArray(int[] arr)
{
    int length = arr.Length; 
    int index = 0; 
    while(index < length)
    {
        arr[index] = Convert.ToInt32(Console.ReadLine());
        index++; 
    }
}

//Подсчет количества четных чисел в массиве
int PositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}