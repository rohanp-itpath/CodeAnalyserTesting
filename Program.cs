using Testing;

public class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Enter a number to calculate factorial: ");
    // ⚠️ WARNING: [Medium Priority - syntax]
    // ISSUE: [Semantic] The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    // SUGGESTED SOLUTION: Review the static analysis violation and adjust the code according to best practices.
        string? input = Console.ReadLine();

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
