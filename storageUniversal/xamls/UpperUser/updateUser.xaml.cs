﻿using System;
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
using System.Windows.Input;

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
            //בודק שהאימייל תקין
            if (Register.isEmailValid(newemail.Text))
            {
                var resTemp = await UDBS.updateUserAsync(FullUser, NewUser);
                bool res = resTemp;
                if (res)
                {
                    var secsussPop = new ContentDialog()
                    {
                        Title = "Detailes Update Have Been Sucsussfully Completed",
                        CloseButtonText = "ok"
                    };
                    await secsussPop.ShowAsync();
                    FullUser = NewUser;
                    Frame.Navigate(typeof(UpperLogin));
                }
                else
                {
                    var failPop = new ContentDialog()
                    {
                        Title = "Detailes Update Have Been Unsecsussfull",
                        Content = "Please try again.",
                        CloseButtonText = "ok"
                    };
                    await failPop.ShowAsync();
                }
            }
            else
            {
                var invalidEmail = new ContentDialog() { Title = "Invalid Email address", Content = "please enter a valid Email adress", CloseButtonText = "ok" };
                await invalidEmail.ShowAsync();
            }



        }
        //deletes user from system
        //מוחק את המשתמש
        private async void DelBot_Click(object sender, RoutedEventArgs e)
        {
            //שואל את המשתמש אם הוא בטוח שהוא רוצה להימחק
            
            var delMsg = new ContentDialog() { Title = "Notice", Content = "You are about to delete all your data from our systems, are you sure?", CloseButtonText="Cancel", SecondaryButtonText = "ok, delete me", SecondaryButtonCommandParameter= this };
            delMsg.SecondaryButtonCommand = new deleteButtonCommand() ;
            await delMsg.ShowAsync();
        }
        public async void deleteUser()
        {
            var usr = UpperLogin.FullUser;
            var a = await UDBS.DeleteUserAsyncAsync(usr);
            if (a)
            {
                var sucsess = new ContentDialog() {  CloseButtonText="ok" ,Title = "Sucsess", Content = "All your data is now gone." };
                await sucsess.ShowAsync();
                Frame.Navigate(typeof(MainPage));
            }
            else
            {
                var fail = new ContentDialog() { CloseButtonText = "ok", Title = "Failiur", Content = "Operation failed, please try again." };
                await fail.ShowAsync();
            }
        }
        class deleteButtonCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            public void Execute(object parameter)
            {
                var page = parameter as updateUser;
                page.deleteUser();
            }
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
