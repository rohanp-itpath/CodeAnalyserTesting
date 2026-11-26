using Microsoft.Extensions.Logging;
using System;

namespace Testing;

public class Condition
{
	private readonly bool _isFlag;
	public void CheckCondition()
	{
        _logger?.LogInformation(
            "Checking condition. Flag value: {Flag}",
            _isFlag);

        Console.WriteLine("Condition checked");
    }
}
