// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Вводим координаты первой точки
Console.Write("Enter X coordinates of point 1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y coordinates of point 1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Z coordinates of point 1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

//Вводим координаты второй точки
Console.Write("Enter X coordinates of point 2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y coordinates of point 2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Z coordinates of point 2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//Метод расчета расстояния между точками
double GetDistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),2);
    return dist;
}

//Вызов метода
Console.WriteLine($"Distance between dots: {GetDistance(x1, y1, z1, x2, y2, z2)}");
