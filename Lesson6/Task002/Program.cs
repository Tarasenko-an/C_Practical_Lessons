//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] func1 = new double[2];
double[] func2 = new double[2];
Console.WriteLine("Determination of the point of intersection of the lines given by the equations:/ny = k1 * x + b1/ny = k2 * x + b2");

//Вводим значения функций
InputValues(func1, "Enter variable values k1, b1 function: y = k1 * x + b1");
InputValues(func2, "Enter variable values k1, b1 function: y = k2 * x + b2");

//Вычисляем точку пересечения
GetCrossing(func1, func2);

//Метод ввода значений функции
void InputValues(double[] arr, string mess)
{
    Console.WriteLine(mess);
    int length = arr.Length; 
    int index = 0; 
    while(index < length)
    {
        arr[index] = Convert.ToInt32(Console.ReadLine());
        index++; 
    }
}

//Метод определения точки пересечения функций
void GetCrossing(double[] func1, double[] func2)
{   

    double CoordinateX =  (func1[1]-func2[1])/(func2[0]-func1[0]);
    double CoordinateY =  func1[0]*(func1[1]-func2[1])/(func2[0]-func1[0]) + func1[1];
    Console.WriteLine($"Intersection point: [{CoordinateX}, {CoordinateY}]");
}

