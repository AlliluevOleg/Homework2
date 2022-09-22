


int n = Prompt("Введите число элементов массива");
int[] array = new int[n];
Fillarray(array);
PrintArray(array);
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void Fillarray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = Prompt("Введите чиссло");
    }
}
void PrintArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine("Больше нуля "  + count);
}
