using System;

namespace Testing;

public class Condition
{
    private readonly bool _isFlag;

    public Condition(bool isFlag = true)
    {
        _isFlag = isFlag;
    }

    public void CheckCondition()
    {
        // Duplicate Block #1
        if (_isFlag)
        {
            Console.WriteLine("Condition is true.");
        }
        else
        {
            Console.WriteLine("Condition is false.");
        }

        // Duplicate Block #2
        if (_isFlag)
        {
            Console.WriteLine("Condition is true.");
        }
        else
        {
            Console.WriteLine("Condition is false.");
        }

        // Duplicate Block #3
        int total = 0;

        for (int i = 0; i < 5; i++)
        {
            total += i;

            if (total > 2)
            {
                Console.WriteLine($"Total: {total}");
            }
        }

        // Duplicate Block #4
        int anotherTotal = 0;

        for (int i = 0; i < 5; i++)
        {
            anotherTotal += i;

            if (anotherTotal > 2)
            {
                Console.WriteLine($"Total: {anotherTotal}");
            }
        }
    }

    // Duplicate Method #1
    public void ValidateCondition()
    {
        if (_isFlag)
        {
            Console.WriteLine("Condition is true.");
        }
        else
        {
            Console.WriteLine("Condition is false.");
        }
    }

    // Duplicate Method #2
    public void VerifyCondition()
    {
        if (_isFlag)
        {
            Console.WriteLine("Condition is true.");
        }
        else
        {
            Console.WriteLine("Condition is false.");
        }
    }

    // Large Duplicate Method #3
    public void ProcessNumbers()
    {
        int total = 0;

        for (int i = 0; i < 5; i++)
        {
            total += i;

            if (total > 2)
            {
                Console.WriteLine($"Total: {total}");
            }
        }
    }

    // Large Duplicate Method #4
    public void CalculateNumbers()
    {
        int total = 0;

        for (int i = 0; i < 5; i++)
        {
            total += i;

            if (total > 2)
            {
                Console.WriteLine($"Total: {total}");
            }
        }
    }
}