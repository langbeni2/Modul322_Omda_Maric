namespace Modul322_Omda_Maric
{
    public partial class AddProductPage : ContentPage
    {
        public AddProductPage()
        {
            InitializeComponent();
        }

        private void OnIconSelected(object sender, EventArgs e)
        {
            // Beispiel: markiere den ausgewählten Icon-Button
            var btn = sender as ImageButton;
            if (btn == null)
                return;
        }
        private async void OnCancelCommandExecuted(object sender, EventArgs e)
        {
            var addPage = new MainPage();
            // Navigate back to the MainPage
            await Navigation.PushAsync(addPage);


        }
    }
}
