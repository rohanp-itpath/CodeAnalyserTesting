namespace Testing; // Removes one level of indentation and one set of braces

public class ArmstrongNumber
{
	public static bool IsArmstrong(int number)
	{
		int sum = 0;
		int temp = number;
		int digits = number.ToString().Length;

		while (temp > 0)
		{
			int digit = temp % 10;
			sum += (int)Math.Round(Math.Pow(digit, digits));
			temp /= 10;
		}

		//return sum == number;
	}
} // Only one brace needed here for the class!
