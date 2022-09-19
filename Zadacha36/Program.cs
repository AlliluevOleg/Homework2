void Fillarray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
}
int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SummNech(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

int size = DataEntry("Введите размер массива: ");
int[] array = new int[size];
Fillarray(array);
Console.Write("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных элемнтов равна {SummNech(array)}");
