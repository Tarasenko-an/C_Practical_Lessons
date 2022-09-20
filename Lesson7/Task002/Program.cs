// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int row = new Random().Next(3, 10);
int column = new Random().Next(3, 10); 
int[,] array = CreateArray(row, column, -99, 100);
PrintArray(array);
FindElement(array);

//Заполнение массива случайными числами
int[,] CreateArray(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(min, max); 
        }
    }
    return result;
}

//Вывод массива
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);    
    int columns = array.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Поиск элемента массива
void FindElement(int[,] arr)
{
    int[] pos = new int[2];
    Console.WriteLine("Enter array element position [x, y]: ");
    pos[0] = Convert.ToInt32(Console.ReadLine());
    pos[1] = Convert.ToInt32(Console.ReadLine());
    if ((pos[0] >= 0) && (pos[1] >= 0) && (pos[0] < arr.GetLength(0)) && (pos[1] < arr.GetLength(1)))
    {
        Console.WriteLine($"Array element [{pos[0]}, {pos[1]}] = {arr[pos[0], pos[1]]}");
    }
    else
    {
        Console.WriteLine("There is no such element in the array.");
    }
}