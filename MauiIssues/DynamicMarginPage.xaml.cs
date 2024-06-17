namespace MauiIssues
{
    public partial class DynamicMarginPage : ContentPage
    {
        private double _previousWidth;
        private double _previousHeight;

        public DynamicMarginPage()
        {
            InitializeComponent();
            BindableLayout.SetItemsSource(ItemsList, new[]
            {
                "Test 1",
                "Test 2",
                "Test 3",
                "Test 4",
                "Test 5",
                "Test 6",
                "Test 7",
                "Test 8",
            });
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            base.OnSizeAllocated(width, height);
            if (height < 1 || width < 1 || Math.Abs(width - _previousWidth) < 1 ||
                Math.Abs(height - _previousHeight) < 1)
            {
                return;
            }

            _previousHeight = height;
            _previousWidth = width;
            Container.Margin = new Thickness(0.1 * width, 0.01 * Height);
        }
    }
}