namespace _06Calculator;

public class Calculator
{
   public double Add(double a, double b)
   {
    return a + b;
   }
   public double Subtract( double a, Double b)
   {
    return a - b;
   }
   public double Multiply(double a, double b)
   {
    return a * b;
   }
    public double Divide(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }else
        {
            throw new DivideByZeroException("Bölen sıfır olamaz!");
        }
    }
}
public class ScientificCalculator : Calculator
{
    public double Sin(double angle)
    {
        return Math.Sin(angle);
    }
    public double Cos(double angle)
    {
        return Math.Cos(angle);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator basicCalculator = new Calculator();
        System.Console.WriteLine($"5 + 3 = {basicCalculator.Add(5, 3)}");
        System.Console.WriteLine($"10 - 4 = {basicCalculator.Subtract(10, 4)}");
        System.Console.WriteLine($"7 * 2 = {basicCalculator.Multiply(7, 2)}");
        try
        {
            System.Console.WriteLine($"20 / 4 = {basicCalculator.Divide(20, 4)}");
        }
        catch (DivideByZeroException e)
        {
            System.Console.WriteLine(e.Message);
        }
         ScientificCalculator sciCalculator = new ScientificCalculator();

         double angle = Math.PI / 2;
         System.Console.WriteLine($"Sin(90 derece) = {sciCalculator.Sin(angle)}");
         System.Console.WriteLine($"Cos(90 derece) = {sciCalculator.Sin(angle)}");
    }
}