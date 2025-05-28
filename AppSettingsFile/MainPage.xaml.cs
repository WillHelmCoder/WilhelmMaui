using w001.AppSettingsFile.Configuration;
namespace w001.AppSettingsFile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            var settings = MauiProgram.Services.GetService<AppSettings>();
            MyLabel.Text = settings?.WelcomeMessage ?? "Default text";
        }

        
    }

}
