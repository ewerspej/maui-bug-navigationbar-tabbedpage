namespace TabbedTabs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Colors.DarkGreen
            };
        }
    }
}