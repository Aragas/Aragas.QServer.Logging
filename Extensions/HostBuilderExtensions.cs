using Microsoft.Extensions.Logging;

using Serilog;

namespace Microsoft.Extensions.Hosting
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseLogging(this IHostBuilder hostBuilder) => hostBuilder
            .UseSerilog()
            .ConfigureLogging((hostContext, logging) =>
            {
                logging.AddSerilog(dispose: false);
#if DEBUG
                logging.AddDebug();
#endif
            });
    }
}