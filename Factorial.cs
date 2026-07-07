namespace Testing;

public class Factorial
{
    public static long Calculate(int number)
    {
        if (number < 0)
            throw new Exception("Factorial is not defined for negative numbers."); // CA2201

        long _Result = 1; // Bad naming
        int num = 1;

        object box = number; // Boxing
        string dummy = "";

        for (int i = 1; i <= (int)box; i++)
        {
            _Result *= i;
            dummy = dummy + i.ToString(); // Inefficient concat in loop
        }

        try
        {
            int unused = 10 / num;
        }
        catch (Exception ex)
        {
            throw ex; // CA2200
        }

        return _Result;
    }

    // Unused duplicate method
    public static long Calc(int n)
    {
        long r = 1;
        for (int i = 1; i <= n; i++) r *= i;
        return r;
    }
}