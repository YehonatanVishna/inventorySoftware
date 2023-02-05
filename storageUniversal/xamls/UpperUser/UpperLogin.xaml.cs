using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using storageUniversal.codes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// The page gets the users email and password and signs him in
    /// </summary>

    public sealed partial class UpperLogin : Page
    {
        public static UserDBServ.User usr = new UserDBServ.User();
        public static UserDBServ.User FullUser;
        private UserDBServ.UserDBServSoapClient UDBS = new UserDBServ.UserDBServSoapClient();
        public static Type SentFrom;
        public UpperLogin()
        {
            this.InitializeComponent();
            TryStartAutoLoging();
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
        //checking if the user has previusly signed in, if he did, offering him to use previus login info
        //בודק האם המשתמש כבר נכנס בעבר ממחשב זה,אם כן מציע לו להשתמש בחיבור לפי הפרטים שנשמרו
        private async void TryStartAutoLoging()
        {
            var db = new UsersDatabase();
            var a = await db.GetItemsAsync();
            if (a.Count > 0)
            {
                //in case there is alredy content dialog up, using try to avoid erro
                try
                {
                    //הודעת ההצעה
                    ContentDialog getLandingDits = new ContentDialog()
                    {
                        Title = "do you wish to use saved user?",
                        SecondaryButtonText = "yes",
                        SecondaryButtonCommand = new logSavedUser(),
                        SecondaryButtonCommandParameter = this,
                        CloseButtonText = "no"
                    };
                    await getLandingDits.ShowAsync();
                }
                catch { }
            }
        }
        //tryes to log user in
        // מנסה לחבר את המשתמש אוטומטית, כך שאם לא מצליח לא מעלה שגיאה
        public static async void logAutoCheck(Frame frame, TextBlock res)
        {
            var db = new UsersDatabase();
            var a = await db.GetItemsAsync();
            try
            {
                    autoLogin(a[0], frame, res);
            }
            catch { }
        }
        //logs in user autologin
        // מכניס את המשתמש בכניסה אוטומטית לפי הפרטים השמורים
        public static async void autoLogin(User user, Frame frame, TextBlock res)
        {
            var UDBS = new UserDBServ.UserDBServSoapClient();
            usr.Password = user.Password;
            usr.Email = user.Email;
            var a = await UDBS.IsUserPermittedAsync(new UserDBServ.User() {Password= usr.Password, Email = usr.Email });
            bool b = bool.Parse(a.ToString());
            if (b)
            {

                
                var TempFullUsr = await UDBS.GetFullUserAsync(usr);
                FullUser = TempFullUsr;
                frame.Navigate(typeof(xamls.UpperUserHomePage));
            }
            else
            {
                var fail = new ContentDialog() { Title = "email or password are wrong, try again", CloseButtonText = "ok" };
                await fail.ShowAsync();
            }
        }
        //the command that passes user data to next page from auto login menu
        //הקומנד שיפעל ברגע שהמשתמש יבחר שהוא רוצה להתחבר עם הפרטים השמורים
        public class logSavedUser : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            public async void Execute(object parameter)
            {
                var logPg = (parameter as UpperLogin);
                logAutoCheck(logPg.Frame, logPg.res);
            }

        }

        //logs in user and sends him to his home page
        // מחבר את המשתמש, ושולח אותו לדף הבית
        private async void LoginAndSendToHome(object sender, RoutedEventArgs e)
        {
            usr.Password = password.Password;
            usr.Email = email.Text;
            if (!isEmailValid(usr.Email))
            {
                IsEmailValidBlock.Text = "email address isn't valid";
                return;
            }
            var a = await UDBS.IsUserPermittedAsync(usr);
            if(await UDBS.IsAdminAsync(usr))
            {
                FullUser = new UserDBServ.User() { Email = usr.Email, Password = usr.Password };
                Frame.Navigate(typeof(AdminPanel));
                return;
            }
            var isval = isEmailValid(usr.Email);
            bool b = bool.Parse(a.ToString());
            if (b)
            {
                //raises sucsess popup
                //מעלה הודעת הצלחה
                var sucsess = new ContentDialog() { Title = "user exists, data should be showen", CloseButtonText="ok" };
                await sucsess.ShowAsync();
                var TempFullUsr = await UDBS.GetFullUserAsync(usr);
                FullUser = TempFullUsr;
                if (rememberBox.IsChecked.Value)
                {
                    var db = new UsersDatabase();
                    await db.DeleteAll();
                    await db.InsertItemAsync(new User() { ID = FullUser.ID, Email = FullUser.Email, Password = FullUser.Password , BDate = FullUser.BDate.Value, Compeny = FullUser.Compeny, Fname = FullUser.Fname, Lname = FullUser.Lname});
                }
                this.Frame.Navigate(typeof(xamls.UpperUserHomePage));
            }
            else
            {
                //raises failiur popup
                //מעלה הודעת שגיאה
                var fail = new ContentDialog() { Title = "email or password are wrong, try again", CloseButtonText = "ok" };
                await fail.ShowAsync();
            }
        }
        //בודק האם האימייל שהתקבל תקין בתחביר שלו
        //checks whether the recived email is valid
        public bool isEmailValid(String emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                foreach(char a in emailaddress.ToList())
                {
                    if (a < 32 || a>122)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //send user back to previus page
        //כפתור אחורה- שולח את המשתמש לעמוד הקודם
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }

        private void RegBut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Register));
        }
    }
}
