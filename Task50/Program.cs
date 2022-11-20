//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого числа в массиве нет

Console.WriteLine("Введите первое значение (строка)  элемента  ");
int oneElement = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе значение (столбец)  элемента ");
int twoElement = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[4, 4];

GetArray(matrix);

int a = oneElement - 1;
int v = twoElement - 1;

if (oneElement <= matrix.GetLength(0) && twoElement <= matrix.GetLength(1))
{
    Console.WriteLine(matrix[a, v]);
}
if (oneElement > matrix.GetLength(0) || twoElement > matrix.GetLength(1))
{
    Console.WriteLine("Значение выходит за рамки массива   ");
}

void GetArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(-100, 100);
            Console.Write("{0,7:F0}", inArray[i, j]);
        }
        Console.WriteLine();
    }
}