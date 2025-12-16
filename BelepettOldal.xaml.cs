namespace OraiDolgozatMAUI;

[QueryProperty("Username", "username")]
public partial class BelepettOldal : ContentPage
{
    public BelepettOldal()
    {
        InitializeComponent();
    }

    string username;
    public string Username
    {
        get => username;
        set
        {
            username = value;
            UpdateWelcome();
        }
    }

    void UpdateWelcome()
    {
        if (!string.IsNullOrEmpty(username) && welcomeLabel != null)
        {
            welcomeLabel.Text = $"Üdvözöllek, {System.Net.WebUtility.UrlDecode(username)}!";
        }
    }
}