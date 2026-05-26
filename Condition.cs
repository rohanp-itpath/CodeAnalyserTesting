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
        // Original logic
        if (_isFlag)
        {
            Console.WriteLine("Condition is true.");
        }
        else
        {
            Console.WriteLine("Condition is false.");
        }

        // Duplicate logic block
        if (_isFlag)
        {
            Console.WriteLine("Condition is true.");
        }
        else
        {
            Console.WriteLine("Condition is false.");
        }
    }

    // Another duplicated method
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
}