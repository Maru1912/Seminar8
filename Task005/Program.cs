// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



Console.WriteLine("Введите длину массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
FillArray(array);
PrintArray(array);
Console.WriteLine(Count(array));




void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i  < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
    
}




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArray(numbers);
PrintArray(numbers);



void FillArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        numbers[i] = Convert.ToDouble(new Random().Next(1,100)) / 100;
}
void PrintArray(double[] numbers)
{
    foreach (double item in numbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");







// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArray(numbers);
PrintArray(numbers);



void FillArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        numbers[i] = Convert.ToDouble(new Random().Next(1,100)) / 100;
}
void PrintArray(double[] numbers)
{
    foreach (double item in numbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");