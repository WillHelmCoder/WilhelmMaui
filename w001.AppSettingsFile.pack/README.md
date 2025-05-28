# Xipe.MauiAppSettings

Este paquete a�ade autom�ticamente:

- `appsettings.json` en la ra�z de tu proyecto
- `Configuration/AppSettings.cs` con un `WelcomeMessage`
- `Configuration/AppSettingsRegistrar.cs` con el m�todo `.AddAppSettings()`

## Uso

```csharp
using Configuration;

builder.Services.AddAppSettings();
