
using w002.ShellFactory.Views;

namespace w002.ShellFactory.ShellCompositions
{
    public partial class OpenShell : Shell
    {
        public OpenShell()
        {
            // Registrar las rutas
            Routing.RegisterRoute("OpenPage", typeof(HomePage));
            Routing.RegisterRoute("ListPage", typeof(ListPage));

            // Crear el tab principal con HomePage
            var homeTab = new Tab
            {
                Title = "OpenPage",
                Icon = "dashboard.png"
            };

            homeTab.Items.Add(new ShellContent
            {
                Title = "OpenPage",
                ContentTemplate = new DataTemplate(typeof(HomePage)),
                Route = "OpenPage"
            });

            // Crear otro tab con ListPage
            var listTab = new Tab
            {
                Title = "Lista",
                Icon = "profile.png"
            };
            listTab.Items.Add(new ShellContent
            {
                Title = "Listado",
                ContentTemplate = new DataTemplate(typeof(ListPage)),
                Route = "ListPage"
            });

            // Agregar los tabs al Shell
            Items.Add(homeTab);
            Items.Add(listTab);
        }
    }
}
