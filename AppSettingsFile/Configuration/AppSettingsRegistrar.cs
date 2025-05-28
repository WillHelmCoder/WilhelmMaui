using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using w001.AppSettingsFile.Configuration;

namespace w001.AppSettingsFile.Configuration
{
    public static class AppSettingsRegistrar
    {
        public static IServiceCollection AddAppSettings(this IServiceCollection services, string fileName = "appsettings.json")
        {
            var jsonPath = Path.Combine(AppContext.BaseDirectory, fileName);
            if (!File.Exists(jsonPath))
                throw new FileNotFoundException($"El archivo '{fileName}' no fue encontrado en {jsonPath}");

            var json = File.ReadAllText(jsonPath);
            var settings = JsonSerializer.Deserialize<AppSettings>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (settings == null)
                throw new InvalidOperationException("No se pudo deserializar AppSettings.");

            services.AddSingleton(settings);
            return services;
        }
    }
}
