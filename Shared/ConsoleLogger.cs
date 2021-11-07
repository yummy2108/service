namespace ReleaseServiceDemo.Shared
{
    using System;

    /// <summary>
    /// Console logger implementation.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        private Guid correlationId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLogger"/> class.
        /// </summary>
        public ConsoleLogger()
        {
            this.correlationId = Guid.NewGuid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLogger"/> class.
        /// </summary>
        /// <param name="correlationId">Correlation Id.</param>
        public ConsoleLogger(Guid correlationId)
        {
            this.correlationId = correlationId;
        }

        /// <summary>
        /// Log informational message.
        /// </summary>
        /// <param name="message">Formatted message to log.</param>
        public void LogInfo(string message)
        {
            Console.WriteLine($"[{DateTime.UtcNow}] {this.correlationId} {message}");
        }

        /// <summary>
        /// Log error message.
        /// </summary>
        /// <param name="errorMessage">Formmated error message to log.</param>
        public void LogError(string errorMessage)
        {
            Console.WriteLine($"[{DateTime.UtcNow}] {this.correlationId} Error: {errorMessage}");
        }
    }
}
