namespace Ristorante.Service
{
    public class ConfigureLoggingService
    {

        public ConfigureLoggingService(IServiceCollection services)
        {
            services.AddLogging(l =>
            {
                l.AddConsole();
                l.AddFile("Log.txt");
            });
            new ConfigureLoggingService(services);
        }
    }
}
