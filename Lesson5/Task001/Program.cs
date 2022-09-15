// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[new Random().Next(10, 20)];
FillArray(array, 100, 1000);
ShowArray(array);
Console.WriteLine($"The number of even numbers in the array: {GetCountKrat(array)}");

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

//Подсчет количества четных чисел в массиве
int GetCountKrat(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}