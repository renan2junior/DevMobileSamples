using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WebViewSample
{
    public class MyExtensions
    {
        public static string GetHtml(DependencyObject obj)
        {
            return (string)obj.GetValue(HtmlProperty);
        }

        public static void SetHtml(DependencyObject obj, string value)
        {
            obj.SetValue(HtmlProperty, value);
        }

        // Using a DependencyProperty as the backing store for HTML.  This enables animation, styling, binding, etc… 
                
        public static readonly DependencyProperty HtmlProperty =
           DependencyProperty.RegisterAttached("Html", typeof(string), typeof(MyExtensions), new PropertyMetadata("", OnHtmlChanged));

        private static void OnHtmlChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var wv = d as WebView;
            wv?.NavigateToString((string)e.NewValue);
        }
    }
}