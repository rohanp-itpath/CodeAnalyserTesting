namespace Testing;

public class Palindrome
	{
		// Method to check if a string is a palindrome
		public static bool IsPalindrome(string input)
		{
			if (input == null)
				throw new ArgumentNullException(nameof(input), "Input cannot be null.");

			if (input.Length == 0)
				return false;

			int left = 0;
			int right = input.Length - 1;

			while (left < right)
			{
				if (input[left] != input[right])
					return false;

				left++;
				right--;
			}

			return true;
		}
	}
