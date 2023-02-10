using System;
using System.IO;
using System.Text.RegularExpressions;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Net;
using storageUniversal.xamls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace storageUniversal
{
    /// <summary>
    /// A basic main page that sends user to login or register
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame frame;
        public MainPage()
        {
            InitializeComponent();
            
        }
        override
        protected void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame.IsNavigationStackEnabled = true;

        }
        //sends user to about page
        //שולח את המשתמש לעמוד אודות
        private void About_Click(object sender, RoutedEventArgs e)
        {
            About.SentBy = typeof(MainPage);
            Frame.Navigate(typeof(About));
        }

        private void UpUser_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UpperLogin));
        }

        private void LowerUser_Click(object sender, RoutedEventArgs e)
        {
            frame = Frame;
            Frame.Navigate(typeof(LowerLogin));
        }
    }
}
