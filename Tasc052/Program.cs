// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк массива: ");
int rows = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columnes = Int32.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columnes];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 100);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

double sum = 0;
Console.Write("Cреднее арифметическое элементов каждого столбца: ");
for (int k = 0; k < matrix.GetLength(1); k++)
{
    double average = 0;
    for (int t = 0; t < matrix.GetLength(0); t++)
    {
        sum += matrix[t, k];
    }
    average = sum/rows;
    Console.Write(average +"; ");
}