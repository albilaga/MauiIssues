namespace MauiIssues
{
    //https://github.com/dotnet/maui/issues/23445
    public partial class GridStarRowPage : ContentPage
    {
        private double _previousWidth, _previousHeight;

        public GridStarRowPage()
        {
            InitializeComponent();
            BindableLayout.SetItemsSource(DifficultiesLayout, new List<string>
            {
                "Easy", "Medium", "Hard", "Expert"
            });
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width < 1 || height < 1 || Math.Abs(width - _previousWidth) < 1 ||
                Math.Abs(height - _previousHeight) < 1) return;
            _previousHeight = height;
            _previousWidth = width;
            // Workaround(height);
        }

        private void Workaround(double height)
        {
            if (TitleLabel.Height + ScrollViewContent.ContentSize.Height + ContinueButton.Height > height)
            {
                ContainerGrid.RowDefinitions =
                [
                    new RowDefinition(GridLength.Auto),
                    new RowDefinition(GridLength.Star),
                    new RowDefinition(GridLength.Auto)
                ];
            }
            else
            {
                ContainerGrid.RowDefinitions =
                [
                    new RowDefinition(GridLength.Auto),
                    new RowDefinition(GridLength.Auto),
                    new RowDefinition(GridLength.Auto)
                ];
            }
        }
    }
}