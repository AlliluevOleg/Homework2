Console.WriteLine("Введите размеры массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Random rnd = new Random();
        int tmp = rnd.Next(10, 50);
        while (true)
        {
            if (!Contains(array, tmp))
                break;

            tmp = rnd.Next(10, 50);
        }
        array[i, j] = Convert.ToInt32(new Random().Next(10, 50));
    }
    
}
bool Contains(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
                return true;
        }
    }
    return false;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t ");
    Console.WriteLine();
}