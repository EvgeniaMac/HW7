// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Введите количество строк массива: ");
int rows = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columnes = Int32.Parse(Console.ReadLine());
Console.WriteLine("Какое число будем искать? ");
int found = Int32.Parse(Console.ReadLine());
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
int indexI = 0;
int indexJ = 0;
if (matrix[indexI, indexJ] == found)
{
    indexI++;
    indexJ++;
}
Console.WriteLine(found + "-> искомого числа нет в массиве");