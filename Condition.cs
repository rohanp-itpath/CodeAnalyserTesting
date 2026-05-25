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
		Console.WriteLine(_isFlag ? "Condition is true." : "Condition is false.");
	}
}
