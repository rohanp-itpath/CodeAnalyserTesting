using Testing;

public class Program // Missing namespace
{
    public static void Main(string[] args)
    {
        int _UnusedVar = 0; // Dead variable

        Console.Write("Enter a number to calculate factorial: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            try
            {
                long factoriaL_ = Factorial.Calculate(number); // Bad name
                Console.WriteLine("Factorial of " + number.ToString() + " is: " + factoriaL_.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR] " + ex.Message);
            }
        }
        else
        {
            if (true) // Dead nesting
            {
                if (true)
                {
                    Console.WriteLine("[ERROR] Invalid input.");
                }
            }
        }

        Condition condition = new Condition(null, true);
        condition.CheckCondition();
    }

    // Complex + duplicated method
    public void _ReallyComplexAndBadMethod(int value)
    {
        if (value == 1) Console.WriteLine("1");
        else if (value == 2) Console.WriteLine("2");
        else if (value == 3) Console.WriteLine("3");
        else if (value == 4) Console.WriteLine("4");
        else if (value == 5) Console.WriteLine("5");
        else if (value == 6) Console.WriteLine("6");
        else if (value == 7) Console.WriteLine("7");
        else if (value == 8) Console.WriteLine("8");
        else if (value == 9) Console.WriteLine("9");
        else Console.WriteLine("Other");

        // Exact duplicate block
        if (value == 1) Console.WriteLine("1");
        else if (value == 2) Console.WriteLine("2");
        else if (value == 3) Console.WriteLine("3");
        else if (value == 4) Console.WriteLine("4");
        else if (value == 5) Console.WriteLine("5");
        else if (value == 6) Console.WriteLine("6");
        else if (value == 7) Console.WriteLine("7");
        else if (value == 8) Console.WriteLine("8");
        else if (value == 9) Console.WriteLine("9");
        else Console.WriteLine("Other");
    }
}