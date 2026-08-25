using Testing;

public class Program
{
    public static void Main(string[] args)
    {
        // =========================
        // Factorial Section
        // =========================
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
        Console.Write("Enter a number to calculate factorial: ");
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [Medium Priority - syntax]
    // ISSUE: [Semantic] The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    // SUGGESTED SOLUTION: Review the static analysis violation and adjust the code according to best practices.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [Medium Priority - syntax]
    // ISSUE: [Semantic] The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    // SUGGESTED SOLUTION: Review the static analysis violation and adjust the code according to best practices.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [Medium Priority - syntax]
    // ISSUE: [Semantic] The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    // SUGGESTED SOLUTION: Review the static analysis violation and adjust the code according to best practices.
        string? input = Console.ReadLine();

        // Validate input
        if (int.TryParse(input, out int number))
        {
            try
            {
                // Call factorial logic
                long factorial = Factorial.Calculate(number);

                // Output result
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'Exception' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'Exception' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'Exception' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
            catch (Exception ex)
            {
                // Handle runtime errors safely
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
                Console.WriteLine($"[ERROR] {ex.Message}");
            }
        }
        else
        {
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
            Console.WriteLine("[ERROR] Invalid input. Please enter a valid integer.");
        }

    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The name 'Console' does not exist in the current context
    // SUGGESTED SOLUTION: Add 'using System;' at the top of the file.
        Console.WriteLine();

    }
}
