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

            NumeroUnifenas = Environment.GetEnvironmentVariable("NumeroUnifenas");
            if (string.IsNullOrEmpty(Issuer))
                NumeroUnifenas = appSettingsSection["NumeroUnifenas"];

            ApiPython = Environment.GetEnvironmentVariable("ApiPython");
            if (string.IsNullOrEmpty(Issuer))
                ApiPython = appSettingsSection["ApiPython"];
        }

        public string ConnOdonTrack { get; set; }
        public string AllowOrigins { get; set; }
        public string SharedKeyToken { get; set; }
        public string Issuer { get; set; }
        public string NumeroUnifenas { get; set; }
        public string ApiPython { get; set; }
    }
}
