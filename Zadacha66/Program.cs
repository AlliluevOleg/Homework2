Console.Write("Введите начальное число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите начальное число N: ");
int numberN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void Summ (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма {sum}"); 
        return;
    }
    sum = sum + (numberM++);
 Summ(numberM, numberN, sum);
}
 Summ(numberM, numberN, 0);