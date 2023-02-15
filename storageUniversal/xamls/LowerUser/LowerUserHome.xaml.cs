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
using storageUniversal.xamls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal.xamls.LowerUser
{
    /// <summary>
    /// this is the home page the user starts from.
    /// From here, the user can go to other pages in the app
    /// </summary>
    public sealed partial class LowerUserHome : Page
    {
        public LowerUserHome()
        {
            this.InitializeComponent();
            //קוד לניווט עם כפטורי העכבר
            var mouse = new codes.backMouse();
        }
        //שולח את המשתמש למסך ההזמנה
        private void SendToOrderPage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LowerUserOrdePage));
        }
        //שולח את המשתמש לראות את ההזמנות שכבר שלח
        private void OrderedItems_Click(object sender, RoutedEventArgs e)
        {
            
            Frame.Navigate(typeof(LowerSeeOrders), Frame);
        }
        // מגיב ללחיצה על כפתור החזרה, מחזיר את המשתמש למסך הקודם
        //go back to previus page
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
