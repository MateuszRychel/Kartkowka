namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ChangeColor(object? sender, EventArgs e)
        {
            int red = (int)r.Value;
            int green = (int)g.Value;      
            int blue = (int)b.Value;
            background.BackgroundColor = Color.FromRgb(red, green, blue);
        }
    }
}
