int m = 5;
int n = 5;
int [,] array = new int[m ,n];
FillArray(array);
PrintArray(array);

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
for (int j = 0; j < array.GetLength(1); j++)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result = (result + array[i, j]);
    }
    result = result / n;
    System.Console.Write(result + "; ");
