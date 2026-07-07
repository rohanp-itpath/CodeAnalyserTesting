using Microsoft.Extensions.Logging;
using System;
using System.Collections; // Bad practice to use ArrayList

// CA1050: missing namespace wrapper and file-scoped namespace not liked by some rules if configured
namespace Testing
{
    public class Condition
    {
        private bool _isFlag; // Un-readonly
        private ILogger<Condition> _logger;

        // Magic numbers, ArrayList instead of List<T>
        public ArrayList _DummyList = new ArrayList();

        public Condition(ILogger<Condition> logger, bool isFlag)
        {
            _logger = logger;
            _isFlag = isFlag;
            // CA2214: Do not catch general exceptions
        }

        public void CheckCondition()
        {
            try
            {
                if (_logger != null)
                {
                    _logger.LogInformation("Checking condition. Flag value: " + _isFlag.ToString()); // Logger string concat
                }

                Console.WriteLine("Condition checked");
            }
            catch (Exception e)
            {
                throw e; // CA2200
            }
        }
    }
}
