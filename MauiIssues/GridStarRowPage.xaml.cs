namespace MauiIssues
{
    public partial class GridStarRowPage : ContentPage
    {
        public GridStarRowPage()
        {
            InitializeComponent();
            BindableLayout.SetItemsSource(DifficultiesLayout, new List<string>
            {
                "Easy", "Medium", "Hard", "Expert"
            });
        }
    }
}