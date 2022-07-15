/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
//Метод для создания двумерного массива типа double
double[,] fillArray(int m, int n)
{   
    double[,] newArray = new double[m,n];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().NextDouble() * 10;
        }
    }
    return newArray;
}
void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i,j]:F2} ");
        }
        Console.WriteLine();
    }
}

//Создаём массив.
double[,] doubleArray = fillArray(10, 10);
//Вывод массива на печать на печать.
printArray(doubleArray);
