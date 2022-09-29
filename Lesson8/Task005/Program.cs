// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int [,] array = new int[4,4];
SpiralInput(array);
PrintArray(array);

//Заполнение массива по спирали
void SpiralInput(int[,] arr)
{
    int val = 1;
    int x = -1;
    int y = 0;
    int N = arr.GetLength(0);   
    for (int i = 1; i < 2*N; i++)
    {
        for (int j = 0; j < N-i/2; j++)
        {
            arr[y += (i%4 - 1)%2, x -= (i%4 - 2)%2] = val++;
        }
}
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