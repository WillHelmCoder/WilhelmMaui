
using System.Text.Json;



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
