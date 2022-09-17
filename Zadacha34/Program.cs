

void Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
}
int Count (int[] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Count++;
        }
    }
    return Count;
}
int CheckNum(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine);
}


int size = 10;
int[] array = new int [size];
Fillarray(array);

System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine($"В массиве {Count(array)} чисел кратных {2}");