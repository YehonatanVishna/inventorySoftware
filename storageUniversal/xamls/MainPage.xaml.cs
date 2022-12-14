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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace storageUniversal
{
    /// <summary>
    /// A basic main page that sends user to login or register
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // some code to handle mouse back + forward buttons
            Window.Current.Activate();
            Window.Current.CoreWindow.PointerPressed += CoreWindow_PointerPressed;
        }
        // some code to handle mouse back + forward buttons
        private void CoreWindow_PointerPressed(CoreWindow sender, PointerEventArgs args)
        {
            if (args.CurrentPoint.Properties.IsXButton1Pressed)
            {
                Frame frame = Window.Current.Content as Frame;
                if (frame.CanGoBack)
                {
                    frame.GoBack();
                }
            }
            else
            {
                if (args.CurrentPoint.Properties.IsXButton2Pressed)
                {
                    Frame frame = Window.Current.Content as Frame;
                    if (frame.CanGoForward)
                    {
                        frame.GoForward();
                    }
                }
            }
        }
        //sends user to login
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            login.SentFrom = typeof(MainPage);
            this.Frame.Navigate(typeof(login));
        }
        //sends user to register
        private void Logon_Click(object sender, RoutedEventArgs e)
        {
            Register.SentFrom = typeof(MainPage);
            Frame.Navigate(typeof(Register));
        }
        //sends user to about page
        private void About_Click(object sender, RoutedEventArgs e)
        {
            About.SentBy = typeof(MainPage);
            Frame.Navigate(typeof(About));
        }
    }
}
