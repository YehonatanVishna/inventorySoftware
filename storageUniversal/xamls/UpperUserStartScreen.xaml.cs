using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal.xamls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpperUserStartScreen : Page
    {
        public UpperUserStartScreen()
        {
            this.InitializeComponent();
            // some code to handle mouse back + forward buttons
            // קוד להוספת פונקציית קדימה ואחורה לכפתורי העכבר
            Window.Current.Activate();
            Window.Current.CoreWindow.PointerPressed += CoreWindow_PointerPressed;
        }
        // some code to handle mouse back + forward buttons
        // קוד להוספת פונקציית קדימה ואחורה לכפתורי העכבר
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
        //שולח את המשתמש לעמוד הכניסה
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            UpperLogin.SentFrom = typeof(MainPage);
            this.Frame.Navigate(typeof(UpperLogin));
        }
        //sends user to register
        //שולח את המשתמש לעמוד הרשמה
        private void Logon_Click(object sender, RoutedEventArgs e)
        {
            Register.SentFrom = typeof(MainPage);
            Frame.Navigate(typeof(Register));
        }
    }
}
