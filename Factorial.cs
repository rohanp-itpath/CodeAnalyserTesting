namespace Testing;

public class Factorial
	{
		// Iterative factorial method
		public static long Calculate(int number)
		{
			if (number < 0)
				throw new ArgumentException("Factorial is not defined for negative numbers.");

			long result = 1;
			for (int i = 1; i <= number; i++)
			{
				result *= i;
			}
			return result;
	//}
}