using Microsoft.AspNetCore.Mvc;

namespace Ristorante.Service
{
    public class LoggingService : ILoggingService
    {

        private readonly ILogger<LoggingService> logger;

        public LoggingService(ILogger<LoggingService> logger)
        {
            this.logger = logger;
        }

        public int Count = 0;


        public IActionResult Log(string message)
        {
            logger.LogInformation(message);
            Count++;
            System.Diagnostics.Debug.WriteLine($"{Count}-{message}");
            return new ObjectResult(new { ErrorMessage = $"Error {Count}-{message}" });
        }
    }
}
