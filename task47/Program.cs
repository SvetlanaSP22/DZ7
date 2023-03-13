// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(-100, 100) / 10.0;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        
        Console.Write($"{array[m,n],4}\t");
        Console.WriteLine("");
    }
}
Console.WriteLine("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
double [,] array  = new double [rows,cols];
FillArray(array);
Console.WriteLine();
PrintArray(array);


