
using w002.ShellFactory.Views;

namespace w002.ShellFactory.ShellCompositions
{
    public partial class OpenShell : Shell
    {
        public OpenShell()
        {
            Routing.RegisterRoute("SettingsPage", typeof(PremiumPage));
            Routing.RegisterRoute("ManageAccountPage", typeof(ListPage));
            Routing.RegisterRoute("Profile", typeof(HomePage));

            Items.Add(new Tab
            {
                Title = "OpenShell",
                Icon = "dashboard.png",
                Items =
            {
                new ShellContent
                {
                    ContentTemplate = new DataTemplate(typeof(OpenShell)),
                    Route = "AdminDashboard"
                }
            }
            });

            var listTab = new Tab
            {
                Title = "ListPage",
                Icon = "profile.png",
                Items =
            {
                new ShellContent
                {
                    ContentTemplate = new DataTemplate(typeof(ListPage)),
                    Route = "ProfilePage"
                }
            }
            };

            Items.Add(listTab);
        }
    }
}
