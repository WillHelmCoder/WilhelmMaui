using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w002.ShellFactory.Views;

namespace w002.ShellFactory.ShellCompositions
{
    public partial class FreeShell : Shell
    {
        public FreeShell()
        {
            Routing.RegisterRoute("SettingsPage", typeof(PremiumPage));
            Routing.RegisterRoute("ManageAccountPage", typeof(ListPage));
            Routing.RegisterRoute("Profile", typeof(HomePage));

            Items.Add(new Tab
            {
                Title = "FreeShell",
                Icon = "dashboard.png",
                Items =
            {
                new ShellContent
                {
                    ContentTemplate = new DataTemplate(typeof(FreePage)),
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
