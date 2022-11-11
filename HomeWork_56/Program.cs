//Задайте прямоугольный двумерный массив.
//Напишите программу которая будет находить строку с наименьшей суммой элементов
Console.Clear();
Console.WriteLine("введите размер квадратного массива");
int a = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[a, a];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int b = Int32.MaxValue;
int c = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < b)
    {
        b = sum;
        c++;
    }
}
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (c) + ", сумма этих элементов: " + (b));
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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