// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rowA = new Random().Next(2, 4);
int columnA = new Random().Next(2, 4); 
int rowB = new Random().Next(2, 4);
int columnB = new Random().Next(2, 4); 

int[,] matrixA = CreateArray(rowA, columnA, 0, 10);
int[,] matrixB = CreateArray(rowB, columnB, 0, 10);

PrintArray(matrixA, "Array A:");
PrintArray(matrixB, "Array B:");

if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    int[,] matrixC = Multiplication(matrixA, matrixB);
    PrintArray(matrixC, "A * B:");
}
else
{
    Console.WriteLine("Matrices cannot be multiplied");
}

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
void PrintArray(int[,] arr, string text)
{
    int rows = arr.GetLength(0);    
    int columns = arr.GetLength(1);
    Console.WriteLine(text);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    r[i,j] += a[i,k] * b[k,j];
                }
            }
        }
    return r;
}
