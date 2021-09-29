using Libraries.Providers.DateTime.Abstractions;
using System;

namespace Libraries.Providers.DateTime
{
    public class UtcDateTimeProvider : IDateTimeProvider
    {
        public DateTimeOffset Now => DateTimeOffset.UtcNow;
    }
}
