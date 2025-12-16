namespace OraiDolgozatMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register route for BelepettOldal so we can navigate using Shell.Current.GoToAsync("BelepettOldal?username=...")
            Routing.RegisterRoute(nameof(BelepettOldal), typeof(BelepettOldal));
        }
    }
}
