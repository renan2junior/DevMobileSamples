using Windows.ApplicationModel.Calls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UsingPhoneApiApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void BtnCallNumber_OnClick(object sender, RoutedEventArgs e)
        {
            var phoneNumber = TxbPhoneNumber.Text;
            var displayName = TxbDisplayName.Text;
            PhoneCallManager.ShowPhoneCallUI(phoneNumber, displayName);
        }
    }
}