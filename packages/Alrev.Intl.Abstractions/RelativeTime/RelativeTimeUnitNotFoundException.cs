using System;
using System.Runtime.Serialization;

namespace Alrev.Intl.Abstractions.RelativeTime
{
    /// <summary>
    /// The exception that is thrown when a method attempts to construct a relative time style that is not available
    /// </summary>
    public class RelativeTimeUnitNotFoundException : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeTimeUnitNotFoundException"/> class with its message string set to a system-supplied message
        /// </summary>
        public RelativeTimeUnitNotFoundException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeTimeUnitNotFoundException"/> class with the specified error message
        /// </summary>
        /// <param name="message">The error message to display with this exception</param>
        public RelativeTimeUnitNotFoundException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeTimeUnitNotFoundException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception
        /// </summary>
        /// <param name="message">The error message to display with this exception</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception</param>
        public RelativeTimeUnitNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeTimeUnitNotFoundException"/> class with a specified error message and the name of the parameter that is the cause this exception
        /// </summary>
        /// <param name="message">The error message to display with this exception</param>
        /// <param name="paramName">The name of the parameter that is the cause of the current exception</param>
        public RelativeTimeUnitNotFoundException(string message, string paramName) : base(message, paramName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeTimeUnitNotFoundException"/> class with a specified error message, the invalid unit, and a reference to the inner exception that is the cause of this exception
        /// </summary>
        /// <param name="message">The error message to display with this exception</param>
        /// <param name="paramName">The name of the parameter that is the cause of the current exception</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception</param>
        public RelativeTimeUnitNotFoundException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeTimeUnitNotFoundException"/> class using the specified serialization data and context
        /// </summary>
        /// <param name="info">The object that holds the serialized object data</param>
        /// <param name="context">The contextual information about the source or destination</param>
        protected RelativeTimeUnitNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
