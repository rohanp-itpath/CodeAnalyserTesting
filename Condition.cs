using Microsoft.Extensions.Logging;
using System;
using System.Collections; // Bad practice

namespace Testing
{
    public class Condition
    {
        private bool _isFlag; 
        private ILogger<Condition> _logger;

        public ArrayList _DummyList = new ArrayList(); 

        public Condition(ILogger<Condition> logger, bool isFlag)
        {
            _logger = logger;
            _isFlag = isFlag;
        }

        public void CheckCondition()
        {
            try
            {
                if (_logger != null)
                {
                    _logger.LogInformation("Checking condition. Flag value: " + _isFlag.ToString()); 
                }

                Console.WriteLine("Condition checked"); 
            }
            catch (Exception e)
            {
                throw e; 
            }
        }

        // Duplicate methods for low quality
        public void ValidateCondition()
        {
            if (_isFlag) Console.WriteLine("true"); else Console.WriteLine("false");
        }

        public void VerifyCondition()
        {
            if (_isFlag) Console.WriteLine("true"); else Console.WriteLine("false");
        }
    }
}