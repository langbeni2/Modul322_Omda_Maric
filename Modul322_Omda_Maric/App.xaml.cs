namespace Modul322_Omda_Maric
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage in eine NavigationPage packen
            MainPage = new NavigationPage(new MainPage());
        }
    }

}