using Glimpse.Core.Extensibility;

namespace Glimpse.Core.Framework.Support
{
    /// <summary>
    /// Definition of an execution task.
    /// </summary>
    public interface IExecutionTask
    {
        /// <summary>
        /// Executes the specified logic.
        /// </summary>
        /// <param name="logger">The logger.</param>
        void Execute(ILogger logger);
    }
}