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
using Windows.UI.Core;

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
            //sets so links would be opened in browser instad of localy in the app
            webview1.NavigationStarting += async (webViewSender, args) =>
            {
                // Cancel the navigation
                args.Cancel = true;

                // Get the URI of the link that was clicked
                var uri = args.Uri;

                // Open the link in the default external browser
                var success = await Windows.System.Launcher.LaunchUriAsync(uri);

                if (success)
                {
                    // The link was opened successfully
                }
                else
                {
                    // An error occurred, the link could not be opened
                }
            };
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
        //Defines to where the user would 
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }

    }
}
