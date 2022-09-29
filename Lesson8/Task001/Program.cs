// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int row = new Random().Next(3, 10);
int column = new Random().Next(3, 10); 
int[,] array = CreateArray(row, column, 0, 10);
PrintArray(array);
SortArray(array);



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
void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);    
    int columns = arr.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Сортировка строк в двумерном массиве

void SortArray(int[,] arr)
{
    int rows = arr.GetLength(0);    
    int columns = arr.GetLength(1);
    int temp;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = j + 1; k < columns; k++)
            {
                if (arr[i,j] < arr[i,k])
                 {
                    temp = arr[i,j];
                    arr[i,j] = arr[i,k];
                    arr[i,k] = temp;
                }
            }
        }
        
    }
    Console.WriteLine("\n Sorted array: \n");
    PrintArray(arr);
}
