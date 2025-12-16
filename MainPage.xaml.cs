namespace OraiDolgozatMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var username = usernameEntry.Text?.Trim();
            var password = passwordEntry.Text?.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlertAsync("Hiba", "Kérlek töltsd ki a felhasználónevet és a jelszót.", "OK");
                return;
            }

            var users = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "asd", "123" },
                { "demo", "demo123" }
            };

            if (!users.TryGetValue(username, out var storedPassword) || storedPassword != password)
            {
                await DisplayAlertAsync("Hiba", "Hibás felhasználónév vagy jelszó.", "OK");
                return;
            }

            var encoded = System.Net.WebUtility.UrlEncode(username);
            await Shell.Current.GoToAsync($"{nameof(BelepettOldal)}?username={encoded}");
        }
          
        }
    }
