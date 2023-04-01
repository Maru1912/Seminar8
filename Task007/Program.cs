// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/* m = 3, n = 4.
 0,5 7 -2 -0,2
 1 -3,3 8 -9,9
 8 7,8 -7,1 9*/


/*void FillArray(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 31) / 10.0;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],5} \t");
        Console.WriteLine();
    }
}

double[,] array = new double[3, 4];
FillArray(array);
PrintArray(array);*/



/*Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
 и возвращает позицию этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

// Console.WriteLine("Введите значение элемента: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[3, 4];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();







// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-1, 5);
//         }
//     }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],3} \t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }





// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (array[i, j].Equals(num))
//         {
//             Console.WriteLine("Позиция этого элемента: " + (i, j));
//             return;
//         }

//     }

// }

// Console.WriteLine("Такого элемента нет");




/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);





void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 100);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

for (int j = 0; j < array.GetLength(1); j++)
{
    
    double sum = 0;
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    
    Console.WriteLine($"Среднее значение {j}-го столбца { sum / array.GetLength(0) } \t");
}
Console.WriteLine();
