using Microsoft.Extensions.Configuration;

namespace Odon.Track.Application.Configuration
{
    public class AppSettings
    {
        public AppSettings() { }
        public AppSettings(IConfiguration configuration) 
        {
            var appSettingsSection = configuration.GetSection("AppSettings");

            ConnOdonTrack = Environment.GetEnvironmentVariable("ConnOdonTrack");
            if (string.IsNullOrEmpty(ConnOdonTrack))
                ConnOdonTrack = appSettingsSection["ConnOdonTrack"];

            Console.WriteLine(ConnOdonTrack);

            AllowOrigins = Environment.GetEnvironmentVariable("AllowOrigins");
            if (string.IsNullOrEmpty(AllowOrigins))
                AllowOrigins = appSettingsSection["AllowOrigins"];

            SharedKeyToken = Environment.GetEnvironmentVariable("SharedKeyToken");
            if (string.IsNullOrEmpty(SharedKeyToken))
                SharedKeyToken = appSettingsSection["SharedKeyToken"];

            Issuer = Environment.GetEnvironmentVariable("Issuer");
            if (string.IsNullOrEmpty(Issuer))
                Issuer = appSettingsSection["Issuer"];
        }

        public string ConnOdonTrack { get; set; }
        public string AllowOrigins { get; set; }
        public string SharedKeyToken { get; set; }
        public string Issuer { get; set; }
    }
}
