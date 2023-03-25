// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и 
// вывести на экран с пояснениями. Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.






Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Первый массив: ");
FillArray(array);
PrintArray(array);




void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}


void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}

int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");



int index = 0;
while (index < size)
{
    if (array[index] == max)

    {
        Console.WriteLine($"Номер элемента массива мах = {index}");
        break;
    }
    index++;

}


int index2 = 0;
while (index2 < size)
{
    if (array[index2] == min)

    {
        Console.WriteLine($"Номер элемента массива min = {index2}");
        break;
    }
    index2++;

}


int sum = 0;

for (int i = 0; i < array.Length; i++)

    sum += array[i];

Console.WriteLine($"Сумма значений элементов массива  = {sum}");


int[] arrInt = new int[] { max, min, index, index2, sum }; 
string[] arrStr = new string[arrInt.Length];

for (int i = 0; i < arrInt.Length; i++)
{
    arrStr[i] = arrInt[i].ToString();
}
 string result2 = string.Join(" ", arrStr);
 Console.Write($"Второй массив [" + result2 + "]");

 
Array.Sort(array); 
 

int middleIndex = array.Length / 2; 
 

double median; 
if (array.Length % 2 == 0) 
{ 
    
    median = (array[middleIndex - 1] + array[middleIndex]) / 2.0; 
} 
else 
{ 

    median = array[middleIndex]; 
} 
 
Console.WriteLine(); 
Console.WriteLine("Медиана первого массива: " + median);