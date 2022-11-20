//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите количество строк в массиве");
int rows = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в массиве");
int columns = Convert.ToInt32(Console.ReadLine() ?? "0");

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue) + new Random().NextDouble());
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write("{0,7:F1}", inArray[i, j]);
        }
        Console.WriteLine();
    }

}
