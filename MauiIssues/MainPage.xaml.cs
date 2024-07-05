namespace MauiIssues
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Container.Add(CreateLabel(new BorderShadowIssuePage()));
            Container.Add(CreateLabel(new DynamicMarginPage()));
            Container.Add(CreateLabel(new MarginPage()));
            Container.Add(CreateLabel(new GridStarRowPage()));
            Container.Add(CreateLabel(new OutOfScreenLabel()));
        }

        private Label CreateLabel(ContentPage page)
        {
            return new Label
            {
                Text = page.GetType().Name,
                GestureRecognizers =
                {
                    new TapGestureRecognizer
                    {
                        Command = new Command(() => Navigation.PushAsync(page))
                    }
                }
            };
        }
    }
}