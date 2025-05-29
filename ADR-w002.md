# ADR-w002: Dynamic Shell Selection via Factory Pattern

## Context

In .NET MAUI, `Shell` is used as the main navigation container. Depending on the type of user or environment (`Admin`, `Free`, `Premium`, `Open`), we wanted to dynamically load a different `Shell` implementation. Managing this manually with many `if` statements was becoming hard to scale and maintain.

## Decision

We introduced:

- An enum `ShellTypes` with values like `AdminShell`, `FreeShell`, `PremiumShell`, and `OpenShell`.
- A `ShellFactory` that returns the correct `Shell` instance using `IServiceProvider`.

### Instead of:

```csharp
MainPage = new AdminShell();

```
### We do now:
```csharp

MainPage = ShellFactory.Create(ShellTypes.FreeShell);
```
## Why Factory is Better
Centralizes all logic for choosing the appropriate Shell.

Avoids tight coupling in the App constructor.

Easier to test and maintain.

Supports feature flags and environment-based decisions in the future.


## Consequences
The project is now extensible — adding a new Shell type only requires updating the enum and the factory.

It aligns with Dependency Injection best practices (resolves Shell via IServiceProvider).

Makes the MainPage assignment clean and focused.