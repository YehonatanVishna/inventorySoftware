using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using storageUniversal;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal.xamls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class About : Page
    {
        public static Type SentBy;
        public About()
        {
            this.InitializeComponent();
            
        }

        private void Weby_WebResourceRequested(WebView sender, WebViewWebResourceRequestedEventArgs args)
        {
            //var u = new Uri("ms-appx-web:///help.html");
            //weby.Navigate(u);

        }

        private void Weby_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            var a = 0;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(SentBy);
        }
    }
}
