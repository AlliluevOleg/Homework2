void Fillarray(double[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
}
int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
double MaxMin(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
        if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    return Max - Min;
}
int size = DataEntry("Введите размер массива: ");
double[] array = new double[size];
Fillarray(array);
Console.Write("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
System.Console.WriteLine($"разница между максимумом и минимумом равна >  {MaxMin(array)}");
