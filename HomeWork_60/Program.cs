// Сформитруйье трёхмерный массив из неповторяющихся двухзначных чисел.
//Напишите программу которая будет построчно выводить массив добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
Console.Clear();
Console.WriteLine($"Введите размер массива A x B x C: ");
int a = InputNumbers("Введите A: ");
int b = InputNumbers("Введите B: ");
int c = InputNumbers("Введите C: ");
Console.WriteLine($"");

int[,,] array = new int[a, b, c];
CreateArray(array);
WriteArray(array);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array)
{
  for (int i = 0; i < a; i++)
  {
    for (int j = 0; j < b; j++)
    {
//      Console.Write($"a({i}) b({j}) ");
      for (int k = 0; k < c; k++)
      {
        Console.Write( $"{array[i, j, k]}" + $"({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
   // Console.WriteLine();
  }
}

void CreateArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
