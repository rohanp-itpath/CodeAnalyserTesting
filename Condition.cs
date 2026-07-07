using Microsoft.Extensions.Logging;
using System;
using System.Collections; // Bad practice

namespace Testing
{
    public class Condition
    {
        private bool _isFlag; // Should be readonly
        private ILogger<Condition> _logger;

        public ArrayList _DummyList = new ArrayList(); // Bad collection + public field

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
                    _logger.LogInformation("Checking condition. Flag value: " + _isFlag.ToString()); // String concat in log
                }

                Console.WriteLine("Condition checked"); // Console in lib code
            }
            catch (Exception e)
            {
                throw e; // CA2200
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