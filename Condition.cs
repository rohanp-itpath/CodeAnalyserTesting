using Microsoft.Extensions.Logging;
using System;

namespace Testing;

public class Condition
{
	private readonly bool _isFlag;
	private readonly ILogger<Condition>? _logger;


    public Condition(ILogger<Condition>? logger = null, bool isFlag = true)
	{
		_logger = logger;
		_isFlag = isFlag;
	}

	public void CheckCondition()
	{
        _logger?.LogInformation(
            "Checking condition. Flag value: {Flag}",
            _isFlag);

        Console.WriteLine("Condition checked");
    }
}
