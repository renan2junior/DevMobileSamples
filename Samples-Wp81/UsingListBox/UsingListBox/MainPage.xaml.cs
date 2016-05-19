using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UsingListBox
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            this.DataContext = this;
        }

        public List<SystemTech> Technologies => new List<SystemTech>
            {
                new SystemTech
                {
                    Company = "Apple",
                    Platform = "iOS",
                    Technology = "Swift"
                },
                new SystemTech
                {
                    Company = "Microsoft",
                    Platform = "Windows",
                    Technology = "C#"
                },
                new SystemTech
                {
                    Company = "Google",
                    Platform = "Android",
                    Technology = "Java"
                }
            };
    }
}