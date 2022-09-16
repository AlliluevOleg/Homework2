int size = 8;
int[] array = new int [size];
Fillarray(array);

System.Console.WriteLine("[{0}]", string.Join(", ", array));

void Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(1, 100);
    }
}
