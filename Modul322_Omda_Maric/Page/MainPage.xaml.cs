using Modul322_Omda_Maric.Page;

namespace Modul322_Omda_Maric
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // SIGNATUR MUSS GENAU SO LAUTEN:
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // TODO: Lösch-Logik hier
        }

        private async void OnAddClicked(object sender, EventArgs e)
        {
            // Neue Seite erzeugen
            var addPage = new AddProductPage();

            // Navigiere dorthin
            await Navigation.PushAsync(addPage);
        }

        private async void OnInfoClicked(object sender, EventArgs e)
        {
            var addPage = new InfoPage();

            // Navigiere dorthin
            await Navigation.PushAsync(addPage);
        }
    }
}
