// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[new Random().Next(10, 20)];
FillArray(array, -99, 100);
ShowArray(array);
Console.WriteLine($"Sum of numbers in odd array positions: {GetSumOdd(array)}");

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

//Заполнение массива числами в диапазоне от min до max-1
void FillArray(int[] arr, int min, int max)
{
    int length = arr.Length; 
    int index = 0; 
    while(index < length)
    {
        arr[index] = new Random().Next(min, max); 
        index++; 
    }
}

//Подсчет суммы элементов, стоящих на нечётных позициях в массиве
int GetSumOdd(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}