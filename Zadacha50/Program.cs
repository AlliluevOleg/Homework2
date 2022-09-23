int m = 5;
int n = 5;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int rows = DataEntry("Введите индекс строки: ");
int colums = DataEntry("Введите индекс столбца: ");

int DataEntry(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
if (rows < array.GetLength(0) && colums < array.GetLength(1))
    Console.WriteLine(array[rows, colums]);
else
    Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");