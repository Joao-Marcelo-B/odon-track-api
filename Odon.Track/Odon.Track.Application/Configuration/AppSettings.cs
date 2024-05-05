using Microsoft.Extensions.Configuration;

namespace Odon.Track.Application.Configuration
{
    public class AppSettings
    {
        public AppSettings() { }
        public AppSettings(IConfiguration configuration) 
        {
            var appSettingsSection = configuration.GetSection("AppSettings");

            ConnOdonTrack = Environment.GetEnvironmentVariable("ConnDB");
            if (string.IsNullOrEmpty(ConnOdonTrack))
                ConnOdonTrack = appSettingsSection["ConnDB"];

            AllowOrigins = Environment.GetEnvironmentVariable("AllowOrigins");
            if (string.IsNullOrEmpty(AllowOrigins))
                AllowOrigins = appSettingsSection["AllowOrigins"];
        }

        public string? ConnOdonTrack { get; set; }
        public string? AllowOrigins { get; set; }
    }
}
