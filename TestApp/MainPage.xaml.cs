namespace TestApp;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}


    private void OnDetailClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//DetailPage");
    }
    private void OnCateClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//CategoryPage");
    }
    private void OnAboutClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//AboutPage");
    }
    private void OnProfClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ProfilePage");
    }


}

