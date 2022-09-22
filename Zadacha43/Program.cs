double b1 = Prompt("b1 = ");
double k1 = Prompt("k1 = ");
double b2 = Prompt("b1 = ");
double k2 = Prompt("b1 = ");
Point(b1, k1, b2, k2);
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Point(double b1, double k1, double b2, double k2)
{
    double x, y;
    if ((k2 == k1) && (b2 == b1))
        System.Console.WriteLine("Прямые совпадают");
    else if (k2 == k1)
        System.Console.WriteLine("Прямые паралельны");
    else
    {
        x = (b2 - b1) / (k2 - k1);
        y = (k1 * (b2 - b1) / (k1 - k2) + b1);
        System.Console.WriteLine("x= " + x + "y" + y);
    }
}