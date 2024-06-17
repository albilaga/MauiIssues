namespace MauiIssues
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBorderShadowIssuePageTapped(object? sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new BorderShadowIssuePage(), false);
        }

        private void OnDynamicMarginPageTapped(object? sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new DynamicMarginPage(), false);
        }

        private void OnMarginPageTapped(object? sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new MarginPage(), false);
        }
    }
}