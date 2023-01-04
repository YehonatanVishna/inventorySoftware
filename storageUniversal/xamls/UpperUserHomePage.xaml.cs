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
    public sealed partial class UpperUserHomePage : Page
    {
        public UpperUserHomePage()
        {
            this.InitializeComponent();
            // some code to handle mouse back + forward buttons
            //קוד לניווט אחורה וקדימה עם כפטורי הניווט של העכבר
            Window.Current.Activate();
            Window.Current.CoreWindow.PointerPressed += CoreWindow_PointerPressed;
        }
        //קוד לניווט אחורה וקדימה עם כפטורי הניווט של העכבר
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
        //logs in user and sends him to his invntory list
        // מחבר את המשתמש, ושולח אותו לרשימת המלאי שלו
        private void LoginAndSendToInventoryList(object sender, RoutedEventArgs e)
        {
            var usr = login.FullUser;
            this.Frame.Navigate(typeof(InventoryView));
        }
        //the button sends the user to manege his subusers
        //הכפטור שולח את המשתמש לנהל את המשתמשים שמשוייכים אליו
        private void ManegeSubUsers_Click(object sender, RoutedEventArgs e)
        {

        }
        //the button sends the user to edit his ditailes
        //הכפטור שולח את המשתמש לערוך את פרטיו האישיים
        private void GoToChangeDitailes_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(updateUser));
        }

        //מחזיר את המשתמש לעמוד הקודם
        //goes back to previus page
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
