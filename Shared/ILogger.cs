namespace ReleaseServiceDemo.Shared
{
    /// <summary>
    /// Interface that establishes logger contracts.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log informational message.
        /// </summary>
        /// <param name="message">Formatted message to log.</param>
        void LogInfo(string message);

        /// <summary>
        /// Log error message.
        /// </summary>
        /// <param name="errorMessage">Formmated error message to log.</param>
        void LogError(string errorMessage);
    }
}
