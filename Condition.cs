    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'Extensions' does not exist in the namespace 'Microsoft' (are you missing an assembly reference?)
    // SUGGESTED SOLUTION: Ensure Microsoft.Extensions NuGet package is installed or add the correct using directive.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'Extensions' does not exist in the namespace 'Microsoft' (are you missing an assembly reference?)
    // SUGGESTED SOLUTION: Ensure Microsoft.Extensions NuGet package is installed or add the correct using directive.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'Extensions' does not exist in the namespace 'Microsoft' (are you missing an assembly reference?)
    // SUGGESTED SOLUTION: Ensure Microsoft.Extensions NuGet package is installed or add the correct using directive.
using Microsoft.Extensions.Logging;
using System;

namespace Testing;

public class Condition
{
	private readonly bool _isFlag;
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'ILogger<>' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using Microsoft.Extensions.Logging;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'ILogger<>' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using Microsoft.Extensions.Logging;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'ILogger<>' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using Microsoft.Extensions.Logging;' at the top of the file.
	private readonly ILogger<Condition>? _logger;


    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'ILogger<>' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using Microsoft.Extensions.Logging;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'ILogger<>' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using Microsoft.Extensions.Logging;' at the top of the file.
    // ⚠️ WARNING: [High Priority - syntax]
    // ISSUE: [Syntax] The type or namespace name 'ILogger<>' could not be found (are you missing a using directive or an assembly reference?)
    // SUGGESTED SOLUTION: Add 'using Microsoft.Extensions.Logging;' at the top of the file.
    public Condition(ILogger<Condition>? logger = null, bool isFlag = true)
	{
		_logger = logger;
		_isFlag = isFlag;
	}

	public void CheckCondition()
	{
        _logger?.LogInformation(
    // ⚠️ WARNING: [Medium Priority - maintainability]
    // ISSUE: [CA-CQ-004] Magic string literal detected: "Checking condition. Flag value: {Flag}"
    // SUGGESTED SOLUTION: Review the static analysis violation and adjust the code according to best practices.
    // ⚠️ WARNING: [Medium Priority - maintainability]
    // ISSUE: [CA-CQ-004] Magic string literal detected: "Checking condition. Flag value: {Flag}"
    // SUGGESTED SOLUTION: Review the static analysis violation and adjust the code according to best practices.
    // ⚠️ WARNING: [Medium Priority - maintainability]
    // ISSUE: [CA-CQ-004] Magic string literal detected: "Checking condition. Flag value: {Flag}"
    // SUGGESTED SOLUTION: Review the static analysis violation and adjust the code according to best practices.
            "Checking condition. Flag value: {Flag}",
            _isFlag);

        Console.WriteLine("Condition checked");
    }
}
