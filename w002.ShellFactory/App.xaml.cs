using w002.ShellFactory.Enums;
using w002.ShellFactory.ShellCompositions;

namespace w002.ShellFactory
{
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;
        public App(IServiceProvider services)
        {
            InitializeComponent();
            _serviceProvider = services ?? throw new ArgumentNullException(nameof(services));
            
            ShellTypes shellType= ShellTypes.OpenShell;

            Shell shell = shellType switch
            {
                ShellTypes.AdminShell => _serviceProvider.GetService(typeof(AdminShell)) as Shell,
                ShellTypes.FreeShell => _serviceProvider.GetService(typeof(FreeShell)) as Shell,
                ShellTypes.OpenShell => _serviceProvider.GetService(typeof(OpenShell)) as Shell,
                ShellTypes.PremiumShell => _serviceProvider.GetService(typeof(PremiumShell)) as Shell,
                _ => throw new NotImplementedException()
            };

            MainPage = shell; 
        }
    }
}
