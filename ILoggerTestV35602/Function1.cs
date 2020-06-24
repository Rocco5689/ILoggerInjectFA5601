using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ILoggerTestV35602
{

    public class Function1
    {
        private readonly ILogger logger;
        private readonly IMyLoggerProvider _otherClass;

        public Function1(ILogger<Function1> _logger, IMyLoggerProvider otherClass)
        {
            logger = _logger;
            _otherClass = otherClass;
        }

        [FunctionName("Function1")]
        public void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            _otherClass.TestMethod();
            
        }
    }
}
