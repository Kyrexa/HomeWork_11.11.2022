// Задайте две матрицы
// Написать программу которая будет находить произведение двух матриц.
Console.Clear();
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
int size = InputInt("Размер матрицы: ");
int[,] a = new int[size, size];
int[,] b = new int[size, size];
FillArrayRandomNumbers(a);
FillArrayRandomNumbers(b);
int[,] c = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            c[i, j] = c[i, j] + (a[i, k] * b[k, j]);
        }
    }
}
PrintArray(a);
PrintArray(b);
Console.WriteLine("Результирующая матрица");
PrintArray(c);