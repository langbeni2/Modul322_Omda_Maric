namespace Modul322_Omda_Maric.Page;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        // Neue Seite erzeugen
        var addPage = new MainPage();

        // Navigiere dorthin
        await Navigation.PushAsync(addPage);
    }

}