namespace TestApp;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
}