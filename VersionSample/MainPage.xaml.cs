namespace VersionSample;

public partial class MainPage : ContentPage
{
    private readonly string _version = AppInfo.Version.ToString();

    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        VersionLabel.Text = _version;
    }
}