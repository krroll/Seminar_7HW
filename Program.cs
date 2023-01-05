// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите кол-во строк m= ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во строк n= ");
// int n = Convert.ToInt32(Console.ReadLine());
// double [,] matrix = new double [m,n];


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = Math.Round(new Random().Next(-10,10) + new Random().NextDouble(),1) ;;
//         Console.Write(matrix[i,j] + " ");
//     }
//     Console.WriteLine();
// }


// -----------------------------------------------------
// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] matrix = new int [4,4];
// Console.WriteLine("Введите искомый элемент ");
// int num = Convert.ToInt32(Console.ReadLine());
// Boolean find = false;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(10);
//         Console.Write(matrix[i,j] + " ");
//         if (num==matrix[i,j])
//         {
//             find = true;
//         }
//     }
//     Console.WriteLine();
// }

// if (find == true)
// {
//     Console.WriteLine("Такое число в массиве есть");
// } 
// else Console.WriteLine("Такого числа в массиве нет");

// ----------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] matrix = new int [4,4];
double [] array = new double [matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(10);
        array[j] = array[j]+ matrix[i,j];
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

for (int k = 0; k < matrix.GetLength(1); k++)
{
    array[k]= array[k]/matrix.GetLength(1);
}

Console.WriteLine(String.Join("; ",array));