# [Android] NavigationPage.HasNavigationBar="False" doesn't work with TabbedPage

Hiding the navigation bar of a NavigationPage by setting `NavigationPage.HasNavigationBar="False"` doesn't work on Android  when the root page of the NavigationPage is set to a TabbedPage:

# App.xaml.cs

```c#
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
```

# MainPage XAML + code-behind

```xml
<?xml version="1.0" encoding="utf-8" ?>
<TabbedPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:tabbedTabs="clr-namespace:TabbedTabs"
    x:Class="TabbedTabs.MainPage"
    BarBackgroundColor="Orange"
    NavigationPage.HasNavigationBar="False">

    <tabbedTabs:PageOne Title="One" />
    <tabbedTabs:PageTwo Title="Two" />

</TabbedPage>
```

```c#
namespace TabbedTabs
{
    public partial class MainPage : TabbedPage
    {
       public MainPage()
        {
            InitializeComponent();
        }
    }
}
```

This occurs only on Android, iOS and Windows look fine, couldn't test MacCatalyst.