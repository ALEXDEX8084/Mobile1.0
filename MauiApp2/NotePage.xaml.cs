//using static Android.Views.TextClassifiers.TextLinks;


namespace MauiApp2;

public partial class NotePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public NotePage()
	{
		InitializeComponent();

        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);
	}
    private void save_Clicked(object sender, EventArgs e)
    {
        string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    }

    private void delete_Clicked(object sender, EventArgs e)
    {
        if(File.Exists(_fileName))
            File.Delete(_fileName);

        TextEditor.Text = string.Empty;
    }

    private void Minus_Clicked(object sender, EventArgs e)
    {
        try
        {
            double t1 = Double.Parse(TextEditor.Text);
        double t2 = Double.Parse(TextEditor2.Text); 
        Label2.Text = $"{t1} - {t2} = {t1 - t2}";
        }
        catch { Label2.Text = $"Неверный ввод данных"; }
    }

    private void Plus_Clicked(object sender, EventArgs e)
    {
        try
        {
            double t1 = Double.Parse(TextEditor.Text);
            double t2 = Double.Parse(TextEditor2.Text);
            Label2.Text = $"{t1} + {t2} = {t1 + t2}";
        }
        catch { Label2.Text = $"Неверный ввод данных"; }
    }

    private void Multiply_Clicked(object sender, EventArgs e)
    {
        try
        {
            double t1 = Double.Parse(TextEditor.Text);
        double t2 = Double.Parse(TextEditor2.Text);
        Label2.Text = $"{t1} * {t2} = {t1 * t2}";
    }
        catch { Label2.Text = $"Неверный ввод данных"; }
    }

    private void Division_Clicked(object sender, EventArgs e)
    {
        try
        {
            double t1 = Double.Parse(TextEditor.Text);
        double t2 = Double.Parse(TextEditor2.Text);
        Label2.Text = $"{t1} / {t2} = {t1 / t2}";
    }
        catch { Label2.Text = $"Неверный ввод данных"; }
    }
}