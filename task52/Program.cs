/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

//Метод для создания двумерного массива типа double
int[,] fillArray(int m, int n)
{   
    int[,] newArray = new int[m,n];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
    return newArray;
}
//Метод вывода массива в консоль
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
//Метод расчёта среднего арифметичекого каждого столбца.
double[] calculateAverageColumns(int[,] array)
{
    double[] avarageColumns = new double[array.GetLength(1)];
    //итерация столбца
    for (int i = 0; i < array.GetLength(1); i++)
    {   
        //итерация строки
        for(int j = 0; j < array.GetLength(0); j++)
        {
            avarageColumns[i] += array[j, i];            
        }
        avarageColumns[i] /= array.GetLength(0);
    }
    return avarageColumns;
}
//Создание двухмерного массива
int[,] int2dArray = fillArray(5, 3);
//Вывод в консолдь массива.
printArray(int2dArray);
//Рассчёт среднего арифмитичского
double[] avarage = calculateAverageColumns(int2dArray);
Console.WriteLine();
//Вывод на экран среднего арифметического.
foreach (double value in avarage)
{
    Console.Write($"{value:F2} ");
}