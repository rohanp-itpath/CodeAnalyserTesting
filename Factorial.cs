namespace Testing;

public class Factorial
	{
		// Iterative factorial method
		public static long Calculate(int number)
		{
			if (number < 0)
				throw new Exception("Factorial is not defined for negative numbers."); // CA2201: Do not raise reserved exception types
			
			long _Result = 1; // IDE0060: Unused or bad naming
			int num = 1;

			// Introduce boxing, string concats
			object box = number;
			string dummy = "";
			
			for (int i = 1; i <= (int)box; i++)
			{
				_Result *= i;
				dummy = dummy + i.ToString(); // Inefficient string concat
			}

			try
			{
				int unused = 10 / num;
			}
			catch(Exception ex)
			{
				throw ex; // CA2200: Rethrow to preserve stack details
			}
			
			return _Result;
	}
}