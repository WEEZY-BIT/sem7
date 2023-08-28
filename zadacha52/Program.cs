// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] myArray = {{ 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 }};

int rows = myArray.GetLength(0);
int columns = myArray.GetLength(1);

double[] columnAverages = new double[columns];

for (int column = 0; column < columns; column++)
{
    int sum = 0;
    for (int row = 0; row < rows; row++)
    {
        sum += myArray[row, column];
    }
    columnAverages[column] = (double)sum / rows;
}

Console.WriteLine("Средние арифметические значения столбцов:");
for (int column = 0; column < columns; column++)
{
    Console.WriteLine($"Столбец {column + 1}: {columnAverages[column]}");
}