// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int row = new Random().Next(3, 10);
int column = new Random().Next(3, 10); 
int[,] array = CreateArray(row, column, 0, 10);
PrintArray(array);
GetAverage(array);

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

//Нахождение среднеарифметического в столбцах
void GetAverage(int[,] arr)
{
    int rows = array.GetLength(0);    
    int columns = array.GetLength(1);
    double count;
    Console.Write("Arithmetic mean in a column: ");
    for (int j = 0; j < column; j++)
    {
        count = 0.0;
        for (int i = 0; i < row; i++)
        {
            count += array[i, j];
        }
        count /= row;
        Console.Write($"{count}; ");
    }
}
