// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int m = 5; // количество строк
int n = 3; // количество столбцов

// Создаем двумерный массив размером m×n
double[,] array = new double[m, n];

// Создаем объект Random для генерации случайных чисел
Random random = new Random();

// Заполняем массив случайными вещественными числами с тремя числами после запятой
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(random.NextDouble(), 3);
    }
}

// Выводим массив на консоль
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

