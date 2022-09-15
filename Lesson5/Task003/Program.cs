// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[new Random().Next(10, 20)];
FillArray(array, -99, 100);
ShowArray(array);
Console.WriteLine($"The difference between Min and Max in the array: {GetDiffMinMax(array)}");

//Вывод массива на экран
void ShowArray(double[] arr)
{
    Console.Write($"Array: [{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]\n");
}

//Заполнение массива вещественными числами в диапазоне от min до max-1
void FillArray(double[] arr, int min, int max)
{
    int length = arr.Length; 
    int index = 0; 
    while(index < length)
    {
        arr[index] = new Random().NextDouble()*new Random().Next(min, max); 
        index++; 
    }
}

//Рассчет разницы между максимальным и минимальным значениями
double GetDiffMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Min: {min}");
    Console.WriteLine($"Max: {max}");
    return (max-min);
}