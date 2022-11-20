// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 3];

GetArray(matrix);
SumAvgArray(matrix);

void SumAvgArray(int[,] array)
{
    for (int n = 0; n < array.GetLength(1); n++)
    {
        double avg = 0;
        double sum = 0;
        for (int l = 0; l < array.GetLength(0); l++)
        {
            sum = sum + array[l, n];
        }
        avg = sum / array.GetLength(0);
        Console.WriteLine("Cреднее арифметическое элементов в " + (n + 1) + " столбце " + "{0,0:F2}", avg);
    }
}


void GetArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
            Console.Write("{0,5:F0}", inArray[i, j]);
        }
        Console.WriteLine();
    }
}