// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int row = new Random().Next(3, 10);
int column = new Random().Next(3, 10); 
int[,] array = CreateArray(row, column, 0, 10);
PrintArray(array);
SumString(array);



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

//Нахождение строки с минимальной суммой элементов

void SumString(int[,] arr)
{
    int rows = arr.GetLength(0);    
    int columns = arr.GetLength(1);
    int temp = 0, summa = 0, numstring = 0;
    for (int i = 0; i < rows; i++)
    {
        temp = 0;
        for (int j = 0; j < columns; j++)
        {
            temp += arr[i,j];
        }
        if ((temp < summa) || (i == 0)) 
        {
            summa = temp;
            numstring = i;
        }
    }
    Console.WriteLine($"\n {numstring+1} string \n");
}
