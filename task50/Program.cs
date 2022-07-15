/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента 
в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

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

//Создание двухмерного массива.
int[,] actualArray = fillArray(4, 3);

//Вывод массива на экран.
Console.WriteLine("Дан двухмерный массив.");
printArray(actualArray);

//Ввод индексов для поиска элемента.
Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки: ");
int column = Convert.ToInt32(Console.ReadLine());

// Использую try  catch для проверки индексов.
try
{   
    Console.WriteLine("Элемент с индексами [{0}, {1}] равен: {2}", row, column, actualArray[row, column]);
}
catch
{
    Console.WriteLine("Произошла ошибка.");
    Console.WriteLine("Индексы [{0}, {1}] отсутствуют в массиве.", row, column);
}

