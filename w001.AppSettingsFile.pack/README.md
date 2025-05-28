# Xipe.MauiAppSettings

Este paquete añade automáticamente:

- `appsettings.json` en la raíz de tu proyecto
- `Configuration/AppSettings.cs` con un `WelcomeMessage`
- `Configuration/AppSettingsRegistrar.cs` con el método `.AddAppSettings()`

## Uso

```csharp
using Configuration;

builder.Services.AddAppSettings();
