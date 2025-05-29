

using w002.ShellFactory.Enums;
using w002.ShellFactory.ShellCompositions;


namespace w002.ShellFactory.Factories
{
    public class ShellFactory
    {
        private readonly IServiceProvider _services;

        public ShellFactory(IServiceProvider services)
        {
            _services = services;
        }

        public Shell CreateShell(ShellTypes shellType)
        {
            return shellType switch
            {
                ShellTypes.AdminShell => _services.GetRequiredService<AdminShell>(),
                ShellTypes.FreeShell => _services.GetRequiredService<OpenShell>(),
                ShellTypes.PremiumShell => _services.GetRequiredService<PremiumShell>(),
                ShellTypes.OpenShell => _services.GetRequiredService<PremiumShell>(),

            };

             
        }



    }
}
