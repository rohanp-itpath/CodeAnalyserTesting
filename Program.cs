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

		// =========================
		// Armstrong Section
		// =========================
		Console.Write("Enter a number to check if it's an Armstrong number: ");
		string? armstrongInput = Console.ReadLine();

		// Validate input
		if (int.TryParse(armstrongInput, out int armstrongNumber))
		{
			try
			{
				// Call Armstrong logic
				bool isArmstrong = ArmstrongNumber.IsArmstrong(armstrongNumber);

				// Replace ternary with if-else
				Console.WriteLine(isArmstrong ? $"{armstrongNumber} is an Armstrong number." : $"{armstrongNumber} is NOT an Armstrong number.");
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
			Console.WriteLine("[ERROR] Invalid input for Armstrong check. Please enter a valid integer.");
		}

		Condition condition = new Condition();
		condition.CheckCondition();
	}
}