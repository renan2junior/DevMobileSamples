using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace WebViewSample
{   
    public sealed partial class SecondPage : Page
    {
        public SecondPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        public string HtmlText => "<html><body><h1>C# is AWESOME!</h1></body></html>";
    }
}