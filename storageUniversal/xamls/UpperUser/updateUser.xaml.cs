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
        public static UserDBServ.User FullUser = UpperLogin.FullUser;
        public static Type SentFrom;
        public updateUser()
        {
            this.InitializeComponent();
            //מכניס לשדות את הנתונים הנוחכיים של המשתמש
            //fills in user current data
            FN.Text = FullUser.Fname;
            LN.Text = FullUser.Lname;
            newemail.Text = FullUser.Email;
            DateTime time = FullUser.BDate.Value;
            BDate.Date = time.Date;
            compeny.Text = FullUser.Compeny;
            pass.Text = FullUser.Password;
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
        //שולח לשירות הרשת את הנתונים העדכניים של המשתמש
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
                var secsussPop = new ContentDialog()
                {
                    Title = "Detailes Update Have Been Sucsussfully Completed", CloseButtonText="ok"
                };
                await secsussPop.ShowAsync();
                FullUser = NewUser;
                Frame.Navigate(typeof(UpperLogin));
            }
            else
            {
                var failPop = new ContentDialog()
                {
                    Title = "Detailes Update Have Been Unsecsussfull", Content = "Please try again.",
                    CloseButtonText = "ok"
                };
                await failPop.ShowAsync();
            }
            }
        //deletes user from system
        //מוחק את המשתמש
        private async void DelBot_Click(object sender, RoutedEventArgs e)
        {
            var usr = UpperLogin.FullUser;
            var a = await UDBS.DeleteUserAsync(usr);
            bool b = bool.Parse(a.ToString());

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
