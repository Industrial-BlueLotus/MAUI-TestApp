using IronPdf;


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
    private void GeneratePDF(object sender, EventArgs e)
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();
        var doc = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF!</h1> <p>I'm using IronPDF MAUI!</p>");
        //Saves the memory stream as file.
        SaveService saveService = new SaveService();
        saveService.SaveAndView("IronPDF HTML string.pdf", "application/pdf", doc.Stream);
    }

}

