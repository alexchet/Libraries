using System;

namespace Libraries.Providers.DateTime.Abstractions
{
    /// <summary>
    /// The Date Time Provider Abstraction.
    /// </summary>
    public interface IDateTimeProvider
    {
        /// <summary>
        /// The current date and time.
        /// </summary>
        /// <returns>The <see cref="DateTimeOffset" />.</returns>
        DateTimeOffset Now { get; }
    }
}
