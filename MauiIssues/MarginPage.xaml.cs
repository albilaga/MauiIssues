namespace MauiIssues
{
    public partial class MarginPage : ContentPage
    {
        public MarginPage()
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
    }
}