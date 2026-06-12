using WebApplication1.Model;

namespace WebApplication1;

public static class InitConfigOptions
{
    extension(WebApplicationBuilder builder)
    {
        public void ReadConfig()
        {
            builder.Configuration.Sources.Clear();
            IHostEnvironment env = builder.Environment;
            builder.Configuration
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables(prefix: "CustomPrefix_");
        }
    }
}