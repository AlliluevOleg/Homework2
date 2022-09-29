int DataEntry(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int n = DataEntry("Введите число: ");
string Number(int n)
{
    if ( n == 1)
    return n.ToString();
    return n.ToString() + Number(n-1);
}
System.Console.WriteLine(Number(n));