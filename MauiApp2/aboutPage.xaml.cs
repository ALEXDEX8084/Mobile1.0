namespace MauiApp2;

public partial class aboutPage : ContentPage
{
	public aboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
		await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }

    private void Compare_Clicked(object sender, EventArgs e)
    {
        try
        {
            double t1 = Double.Parse(TextEditor.Text);
        double t2 = Double.Parse(TextEditor2.Text);
        if (t1 == t2)
            Label2.Text = $"{t1} = {t2}";
        else if (t1 > t2)
            Label2.Text = $"{t1} > {t2}";
        else if (t1 < t2)
            Label2.Text = $"{t1} < {t2}";
        }
        catch { Label2.Text = $"Неверный ввод данных"; }
    }
}