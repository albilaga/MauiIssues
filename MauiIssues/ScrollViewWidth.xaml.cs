namespace MauiIssues
{
    // https://github.com/dotnet/maui/issues/20590
    public partial class ScrollViewWidth : ContentPage
    {
        private double _previousWidth, _previousHeight;

        public ScrollViewWidth()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width < 1 || height < 1 || Math.Abs(_previousHeight - height) < 1 ||
                Math.Abs(_previousWidth - width) < 1)
            {
                return;
            }

            _previousHeight = height;
            _previousWidth = width;
            // ScrollView.WidthRequest = Width;
        }

        private void TapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}