using Microsoft.Extensions.Configuration;

namespace Odon.Track.Application.Configuration
{
    public class AppSettings
    {
        public AppSettings() { }
        public AppSettings(IConfiguration configuration) 
        {
            var appSettingsSection = configuration.GetSection("AppSettings");

            ConnDB = Environment.GetEnvironmentVariable("ConnDB");
            if (string.IsNullOrEmpty(ConnDB))
                ConnDB = appSettingsSection["ConnDB"];

            AllowOrigins = Environment.GetEnvironmentVariable("AllowOrigins");
            if (string.IsNullOrEmpty(AllowOrigins))
                AllowOrigins = appSettingsSection["AllowOrigins"];
        }

        public string? ConnDB { get; set; }
        public string? AllowOrigins { get; set; }
    }
}
