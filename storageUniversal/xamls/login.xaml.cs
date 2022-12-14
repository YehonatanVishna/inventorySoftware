using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// The page gets the users email and password and signs him in
    /// </summary>

    public sealed partial class login : Page
    {
        public static UserDBServ.User usr = new UserDBServ.User();
        public static UserDBServ.User FullUser;
        private UserDBServ.UserDBServSoapClient UDBS = new UserDBServ.UserDBServSoapClient();
        public static Type SentFrom;
        public login()
        {
            this.InitializeComponent();
            TryStartAutoLoging();
        }
        //checking if the user has previusly signed in, if he did, offering him to use previus login info
        private async void TryStartAutoLoging()
        {
            var db = new UsersDatabase();
            var a = await db.GetItemsAsync();
            if (a.Count > 0)
            {
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
        }
        //tryes to log user in
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
        public static async void autoLogin(User user, Frame frame, TextBlock res)
        {
            var UDBS = new UserDBServ.UserDBServSoapClient();
            usr.Password = user.Password;
            usr.Email = user.Email;
            var a = await UDBS.IsUserPermittedAsync(usr);
            bool b = bool.Parse(a.ToString());
            if (b)
            {

                res.Text = "user exists, data should be showen";
                var TempFullUsr = await UDBS.GetFullUserAsync(usr);
                FullUser = TempFullUsr;
                InventoryView.SentFrom = typeof(login);
                frame.Navigate(typeof(InventoryView));
            }
            else
            {
                res.Text = "email or password are wrong, try again";
            }
        }
        //the command that passes user data to next page from auto login menu
        public class logSavedUser : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            public async void Execute(object parameter)
            {
                var logPg = (parameter as login);
                logAutoCheck(logPg.Frame, logPg.res);
            }

        }


        
        //logs in user and sends him to change his personal info
        private async void SendToDitailUpdate(object sender, RoutedEventArgs e)
        {
            
            usr.Password = password.Password;
            usr.Email = email.Text;
            var a = await  UDBS.IsUserPermittedAsync(usr);
            bool b = bool.Parse(a.ToString());
            bool isAdmin = await UDBS.IsAdminAsync(usr);
            if (!isAdmin)
            {
                if (b)
                {
                    res.Text = "user exists, data should be showen";
                    var TempFullUsr = await UDBS.GetFullUserAsync(usr);
                    FullUser = TempFullUsr;
                    updateUser.SentFrom = typeof(login);
                    this.Frame.Navigate(typeof(updateUser));
                }
                else
                {
                    res.Text = "email or password are wrong, try again";
                }
            }
            else
            {
                FullUser = usr;
                AdminPanel.SentFrom = typeof(login);
                this.Frame.Navigate(typeof(AdminPanel));
            }
        }
        //deletes user from system
        private async void DelBot_Click(object sender, RoutedEventArgs e)
        {
            usr.Password = password.Password;
            usr.Email = email.Text;
            var a = await UDBS.DeleteUserAsync(usr);
            bool b = bool.Parse(a.ToString());

        }
        //logs in user and sends him to his invntory list
        private async void LoginAndSendToInventoryList(object sender, RoutedEventArgs e)
        {
            usr.Password = password.Password;
            usr.Email = email.Text;
            var a = await UDBS.IsUserPermittedAsync(usr);
            bool b = bool.Parse(a.ToString());
            if (b)
            {

                res.Text = "user exists, data should be showen";
                var TempFullUsr = await UDBS.GetFullUserAsync(usr);
                FullUser = TempFullUsr;
                if (rememberBox.IsChecked.Value)
                {
                    var db = new UsersDatabase();
                    await db.DeleteAll();
                    await db.InsertItemAsync(new User() { ID = FullUser.ID, Email = FullUser.Email, Password = FullUser.Password , BDate = FullUser.BDate, Compeny = FullUser.Compeny, Fname = FullUser.Fname, Lname = FullUser.Lname});
                }
                InventoryView.SentFrom = typeof(login);
                this.Frame.Navigate(typeof(InventoryView));
            }
            else
            {
                res.Text = "email or password are wrong, try again";
            }
        }
        //send user back to previus page
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(SentFrom);
        }
    }
}
