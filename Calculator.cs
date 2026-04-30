namespace MyApp;
public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Minus(int a, int b) => a - b;
    public int Umnoz(int a, int b) => a * b;
    public double Delit(int a, int b)
    {
        if (a == 0 | b == 0)
        {
            Console.WriteLine("Ошибка -1: делить на ноль нельзя.");
        }
        return (double)a/b;
    }
}   