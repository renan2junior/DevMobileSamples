using System;
using Windows.ApplicationModel.Email;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace UsingEmailApiApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private async void BtnSend_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var emailRecipient = new EmailRecipient
            {
                Address = TxbRecipient.Text
            };

            var emailMessage = new EmailMessage
            {
                Subject = TxbSubject.Text,
                Body = TxbBody.Text                
            };
            emailMessage.To.Add(emailRecipient);

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }
    }
}