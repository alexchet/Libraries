using Libraries.Providers.DateTime;
using Libraries.Providers.DateTime.Abstractions;
using Libraries.Providers.DateTime.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Libraries.Providers.Unit.Test
{
    [Trait("Category", "Unit")]
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void AddUtcDateTimeProvider_ServiceRegistration_Success()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddUtcDateTimeProvider()
                .BuildServiceProvider();

            Assert.IsType<UtcDateTimeProvider>(serviceProvider.GetService<IDateTimeProvider>());
        }

        [Fact]
        public void AddLocaleTimeProvider_ServiceRegistration_Success()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddLocaleDateTimeProvider()
                .BuildServiceProvider();

            Assert.IsType<LocaleDateTimeProvider>(serviceProvider.GetService<IDateTimeProvider>());
        }
    }
}
