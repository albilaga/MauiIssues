namespace MauiIssues
{
    // https://github.com/dotnet/maui/issues/23755
    public partial class GridBackground : ContentPage
    {
        public GridBackground()
        {
            InitializeComponent();
        }

        private void BoxViewTapped(object? sender, TappedEventArgs e)
        {
            Popup.IsVisible = false;
        }

        private void Button_OnClicked(object? sender, EventArgs e)
        {
            Popup.IsVisible = false;
        }
    }
}