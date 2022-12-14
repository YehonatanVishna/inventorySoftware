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
using System.Threading;
using Windows.UI.Core;

//made by yehonatan vishna
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// a page that allows user to update his personal details
    /// </summary>
    public sealed partial class updateUser : Page
    {
        private UserDBServ.UserDBServSoapClient UDBS = new UserDBServ.UserDBServSoapClient();
        public static UserDBServ.User FullUser = login.FullUser;
        public static Type SentFrom;
        public updateUser()
        {
            this.InitializeComponent();
            //fills in user current data
            FN.Text = FullUser.Fname;
            LN.Text = FullUser.Lname;
            newemail.Text = FullUser.Email;
            DateTime time = FullUser.BDate;
            BDate.Date = time.Date;
            compeny.Text = FullUser.Compeny;
            pass.Text = FullUser.Password;
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
        //sends motified data to web service
        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            UserDBServ.User NewUser = new UserDBServ.User();
            var date = BDate.Date;
            DateTime time = date.Value.DateTime;
            NewUser.BDate = time;
            NewUser.Fname = FN.Text;
            NewUser.Lname = LN.Text;
            NewUser.Email = newemail.Text;
            NewUser.Password = pass.Text;
            NewUser.Compeny = compeny.Text;
            var resTemp = await UDBS.updateUserAsync(FullUser, NewUser);
            bool res = resTemp;
            if (res)
            {
                isDone.Text = "update complete sucssfuly";
                Frame.Navigate(typeof(login));
            }
            else
            {
                isDone.Text = "update failed";
            }
            }
        //goes back to previus page
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(SentFrom);
        }
    }
    }
