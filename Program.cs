using Testing;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number to calculate factorial: ");
        string? input = Console.ReadLine();

        // Validate input
        if (int.TryParse(input, out int number))
        {
            try
            {
                long factorial = Factorial.Calculate(number);

                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("[ERROR] Invalid input. Please enter a valid integer.");
        }

        Console.WriteLine();

    }
}