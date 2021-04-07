using System;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// The exception that is thrown when a method attempts to construct a relative time style that is not available
    /// </summary>
    public class RelativeTimeUnitNotFoundException : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeTimeUnitNotFoundException"/> class with a specified error message and the name of the parameter that is the cause this exception
        /// </summary>
        /// <param name="message">The error message to display with this exception</param>
        /// <param name="paramName">The name of the parameter that is the cause of the current exception</param>
        public RelativeTimeUnitNotFoundException(string message, string paramName) : base(message, paramName)
        {
        }
    }
}
