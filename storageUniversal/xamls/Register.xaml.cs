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
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// this page allows the user to register (add his ditails db)
    /// </summary>
    public sealed partial class Register : Page
    {
        public static Type SentFrom;
        public Register()
        {
            this.InitializeComponent();
            //קוד לניווט אחורה וקדימה עם כפטורי הניווט של העכבר
            // some code to handle mouse back + forward buttons
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
        //בודק האם האימייל שהתקבל תקין בתחביר שלו
        //checks whether the recived email is valid
        public bool isEmailValid(String email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        // בודק האם האימייל שהתקבל כבר בשימוש במסד הנתונים
        //checks whether the email alredy axists in db
        public async Task<bool> DoesEmailExistAlready(string email)
        {
            var UDBS = new UserDBServ.UserDBServSoapClient();
            return await UDBS.DoesEmailExistAsync(email);
        }
        //מגיב ללחיצה על כפתור ההרשמה, רושם את המשתמש לשירות
        //responds to click on register button, registers user
        private async void RegBot_Click(object sender, RoutedEventArgs e)
        {
            UserDBServ.UserDBServSoapClient UDBS = new UserDBServ.UserDBServSoapClient();
            UserDBServ.User usr = new UserDBServ.User();
            //בודק האם האימיל והססמה תקינים ולא קיימים במערכת
            if (!isEmailValid(email.Text)) {
                IsEmailValidBlock.Text = "email is not valid";
                return;
            }
            bool exists = await DoesEmailExistAlready(email.Text);
            if (exists)
            {
                IsEmailValidBlock.Text = "user with this email already exists, use another email adress"; return;
            }
            if (!pass.Password.Equals(passAgain.Password))
            {
                IsPasswordValidBlock.Text = "passwords don't match, try again"; return;
            }
            var date = BDate.Date;
            if (date != null)
            {
                DateTime time = date.Value.DateTime;
                usr.BDate = time;
                //בודק שהמשתמש לא צעיר מידי
                var age = DateTime.Now - time;
                if(age.TotalDays < ((int)(365.25 * 10)))
                {
                    ContentDialog AgeDialog = new ContentDialog()
                    {
                        Title = "you must be 10 or older to use this service",
                        CloseButtonText = "ok"
                    };
                    await AgeDialog.ShowAsync();
                    return;
                }
            }

            usr.Fname = FN.Text;
            usr.Lname = LN.Text;
            usr.Email = email.Text;
            usr.Password = pass.Password;
            usr.Compeny = compeny.Text;
            //בודק האם כל השדות מלאים
            if(!date.HasValue || usr.Fname == ""|| usr.Lname == ""|| usr.Email == ""|| usr.Password == ""|| usr.Compeny == "") {
                ContentDialog fail = new ContentDialog()
                {
                    Title = "Make sure you fill out all the fileds",
                    CloseButtonText = "ok"
                };
                await fail.ShowAsync();
                return; }
            var a = await UDBS.regAsync(usr);
            bool IsSuccess = bool.Parse(a.ToString());
            //מעלה למשתמש הודעה- האם ההרשמה הסתיימה בהצלחה או לא
            // raises a popup for the user- tells him wether the regestation was completed sucsessfully
            if (IsSuccess)
            {
                ContentDialog sucsessDialog = new ContentDialog()
                {
                    Title = "regestration completed sucssesfully",
                    CloseButtonText = "ok"
                };
                await sucsessDialog.ShowAsync();
                Frame.Navigate(typeof(MainPage));
            }
            else
            {
                ContentDialog FailDialog = new ContentDialog()
                {
                    Title = "regestration failed, please try again",
                    CloseButtonText = "ok"
                };
                await FailDialog.ShowAsync();
            }


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

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }
    }
}
