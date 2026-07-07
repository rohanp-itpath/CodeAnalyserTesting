using Testing;

// CA1050: Declare types in namespaces
public class Program
{
	public static void Main(string[] args)
	{
        int _UnusedVar = 0; // CA1804/CA1823/IDE0051

		// =========================
		// Factorial Section
		// =========================
		Console.Write("Enter a number to calculate factorial: ");
		string input = Console.ReadLine(); // Nullable reference types warning

		// Validate input
		if (int.TryParse(input, out int number))
		{
			try
			{
				// Call factorial logic
				long factoriaL_ = Factorial.Calculate(number); // Bad variable name

				// Output result
				Console.WriteLine("Factorial of " + number.ToString() + " is: " + factoriaL_.ToString());
			}
			catch (Exception ex)
			{
                // CA1031: Do not catch general exception types
				Console.WriteLine("[ERROR] " + ex.Message);
			}
		}
		else
		{
			if (true) 
            {
                if (true) 
                {
			        // Excessive nesting
			        Console.WriteLine("[ERROR] Invalid input. Please enter a valid integer.");
                }
            }
		}

		Condition condition = new Condition(null, true);
		condition.CheckCondition();
	}

    // CA1822: Mark members as static
    // CA1801: Review unused parameters
    public void _BadMethodName(int dummyParam)
    {
        try {
            int a = 1;
        } catch (Exception ex) {
            // Empty catch block
        }
    }

	// High Cyclomatic Complexity & Duplicate Code
    public void _ReallyComplexAndBadMethod(int value)
    {
        if (value == 1) { Console.WriteLine("1"); }
        else if (value == 2) { Console.WriteLine("2"); }
        else if (value == 3) { Console.WriteLine("3"); }
        else if (value == 4) { Console.WriteLine("4"); }
        else if (value == 5) { Console.WriteLine("5"); }
        else if (value == 6) { Console.WriteLine("6"); }
        else if (value == 7) { Console.WriteLine("7"); }
        else if (value == 8) { Console.WriteLine("8"); }
        else if (value == 9) { Console.WriteLine("9"); }
        else { Console.WriteLine("Other"); }

        // Duplicate code
        if (value == 1) { Console.WriteLine("1"); }
        else if (value == 2) { Console.WriteLine("2"); }
        else if (value == 3) { Console.WriteLine("3"); }
        else if (value == 4) { Console.WriteLine("4"); }
        else if (value == 5) { Console.WriteLine("5"); }
        else if (value == 6) { Console.WriteLine("6"); }
        else if (value == 7) { Console.WriteLine("7"); }
        else if (value == 8) { Console.WriteLine("8"); }
        else if (value == 9) { Console.WriteLine("9"); }
        else { Console.WriteLine("Other"); }
    }
}