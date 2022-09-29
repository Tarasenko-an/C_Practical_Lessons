// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int row = new Random().Next(3, 10);
int column = new Random().Next(3, 10); 
int[,,] array = CreateArray(2, 2, 2, 0, 10);
PrintArray(array);

//Заполнение массива случайными числами
int[,,] CreateArray(int x, int y, int z, int min, int max)
{
    int[,,] result = new int[x, y, z];
    int temp;
    for(int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                temp = new Random().Next(min, max); 
                int count = 0;
                for(int q = 0; q < x; q++)
                    for(int w = 0; w < y; w++)
                        for(int e = 0; e < z; e++)
                            if (temp != result[q, w, e]) count++;
                        
                if (count == x*y*z)
                {
                    result[i, j, k] = temp;
                }
                else
                {   
                    k--;
                    continue;
                }
            }
        }
    }
    return result;
}

//Вывод массива
void PrintArray(int[,,] arr)
{
    int x = arr.GetLength(0);    
    int y = arr.GetLength(1);
    int z = arr.GetLength(2);
    
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.WriteLine($"{arr[i, j, k]} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}