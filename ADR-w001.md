# ADR-w001: AppSettings Demonstration in .NET MAUI

## Context

In this ADR, we describe the initial experiment of integrating a configuration file into a .NET MAUI application. The goal is to demonstrate how to include an `appsettings.json` file and retrieve values from it in the UI.

## Decision

We created a blank .NET MAUI project (`w001`) and added a new file: `appsettings.json`. This file lives in the root directory and contains a single string property:

```json
{
  "WelcomeMessage": "Hello from AppSettings!"
}
```

## Consequences

Demonstrates a lightweight way to parameterize behavior without recompiling the app.

Proves the pattern of initializing app-level settings early and injecting them where needed.

Sets up a base for more advanced configuration features (e.g., feature flags, API URLs).