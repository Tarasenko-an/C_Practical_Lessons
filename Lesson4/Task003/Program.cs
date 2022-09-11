// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Метод ввода массива
void CreateArray(int[] arr)
{
    Console.WriteLine("Input array:");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

//Метод вывода массива
void ShowArray(int[] arr)
{
    Console.Write($"Array: [{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]");
}

int[] array = new int[8];
CreateArray(array);
ShowArray(array);