using Microsoft.Extensions.Logging;

namespace ILoggerTestV35602
{
    public class MyLoggerProvider : IMyLoggerProvider
    {
        private ILogger _logger;
        public MyLoggerProvider(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        public void TestMethod()
        {
            _logger.LogInformation("HELLO WORLD!!!");
        }
    }
}