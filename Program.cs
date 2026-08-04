using Testing;

public class Program
{
    public static void Main(string[] args)
    {
        // =========================
        // Factorial Section
        // =========================
        Console.Write("Enter a number to calculate factorial: ");
        string? input = Console.ReadLine();

        // Validate input
        if (int.TryParse(input, out int number))
        {
            try
            {
                // Call factorial logic
                long factorial = Factorial.Calculate(number);

                // Output result
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
            catch (Exception ex)
            {
                // Handle runtime errors safely
                Console.WriteLine($"[ERROR] {ex.Message}");
            }
        }
        else
        {
            // Input validation failed
            Console.WriteLine("[ERROR] Invalid input. Please enter a valid integer.");
        }

        Console.WriteLine();

    }
}