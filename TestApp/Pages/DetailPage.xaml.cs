namespace TestApp;

public partial class DetailPage : ContentPage
{
	public DetailPage()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
}