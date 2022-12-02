using IronPdf;

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

    private void GeneratePDF(object sender, EventArgs e)
    {
        try
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            var doc = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF!</h1> <p>I'm using IronPDF MAUI!</p>");
            //Saves the memory stream as file.
            SaveService saveService = new SaveService();
            saveService.SaveAndView("IronPDF HTML string.pdf", "application/pdf", doc.Stream);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}