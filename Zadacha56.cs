/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SumRows(int[,] array)
{
    int sum = 0;
    int sum1 = 0;
    int a = 0;
for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (j == 0)
            {
                sum1 = array[i,j];
            }
            else
            {
                sum1 = sum1 + array[i,j];
            }
/*             Console.WriteLine($"Сумма первой строки = {sum1} "); */  // Для подсчета суммы элементов первой строки
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (j == 0)
            {
                sum = array[i,j];
            }
            else
            {
                sum = sum + array[i,j];
            }
/*             Console.WriteLine($"Сумма элементов строки {i+1} = {sum} "); */  //Для проверки сумм каждой из строк
        if (sum < sum1)
        {
            sum1 = sum;
            a = i;
        } 
    }
    Console.WriteLine($"Минимальная сумма элементов массива находится в строке {a+1} и равна {sum1} ");
}

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
SumRows(array);