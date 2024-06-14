using Microsoft.Maui.Controls.Shapes;

namespace MauiIssues;

public partial class BorderShadowIssuePage : ContentPage
{
    public BorderShadowIssuePage()
    {
        InitializeComponent();
        FirstClipBorder.SizeChanged += FirstClipBorderOnSizeChanged;
    }

    protected override void OnDisappearing()
    {
        FirstClipBorder.SizeChanged -= FirstClipBorderOnSizeChanged;
        base.OnDisappearing();
    }

    private void FirstClipBorderOnSizeChanged(object? sender, EventArgs e)
    {
        if (FirstClipBorder.Height < 1 || FirstClipBorder.Width < 1)
        {
            return;
        }

        FirstClipBorder.Clip =
            new RoundRectangleGeometry(new CornerRadius(20), new Rect(0, 0, FirstClipBorder.Width, 40));
        SecondClipBorder.Clip =
            new RoundRectangleGeometry(new CornerRadius(20), new Rect(0, 0, FirstClipBorder.Width, 40));
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        FirstBorder.IsVisible = !FirstBorder.IsVisible;
        SecondBorder.IsVisible = !SecondBorder.IsVisible;

        FirstClipBorder.IsVisible = !FirstClipBorder.IsVisible;
        SecondClipBorder.IsVisible = !SecondClipBorder.IsVisible;
    }
}