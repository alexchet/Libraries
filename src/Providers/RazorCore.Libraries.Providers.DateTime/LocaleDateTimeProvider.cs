using Libraries.Providers.DateTime.Abstractions;
using System;

namespace Libraries.Providers.DateTime
{
    public class LocaleDateTimeProvider : IDateTimeProvider
    {
        public DateTimeOffset Now => DateTimeOffset.Now;
    }
}
