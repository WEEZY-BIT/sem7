// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] myArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

Console.Write("Введите номер строки: ");
int rowInput = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int columnInput = int.Parse(Console.ReadLine());

int result = GetElementValue(myArray, rowInput, columnInput);
if (result == -1)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента: {result}");
}
    

    static int GetElementValue(int[,] array, int row, int column)
{
    if (row < 0 || column < 0 || row >= array.GetLength(0) || column >= array.GetLength(1))
    {
        return -1;
    }
    else
    {
        return array[row, column];
    }
}
