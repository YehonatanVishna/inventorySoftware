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
    /// An empty page that can be used on its own or navigated to within a Frame.
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


        

        private async void SendEmailPass_Click(object sender, RoutedEventArgs e)
        {
            
            usr.Password = password.Text;
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

        //private async void Update_Click(object sender, RoutedEventArgs e)
        //{
        //    if (usr != null) {

        //        UserDBServ.User NewUser = new UserDBServ.User();
        //        var date = BDate.Date;
        //        DateTime time = date.Value.DateTime;
        //        NewUser.BDate = time;
        //        NewUser.Fname = FN.Text;
        //        NewUser.Lname = LN.Text;
        //        NewUser.Email = newemail.Text;
        //        NewUser.Password = pass.Text;
        //        NewUser.Compeny = compeny.Text;
        //        UserDBServ.updateUserResponse resTemp = await UDBS.updateUserAsync(usr, NewUser);
        //        bool res = resTemp.Body.updateUserResult;
        //        if (res) {
        //            isDone.Text = "update complete sucssfuly";
        //        }
        //        else
        //        {
        //            isDone.Text = "update failed";
        //        }
        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void DelBot_Click(object sender, RoutedEventArgs e)
        {
            usr.Password = password.Text;
            usr.Email = email.Text;
            var a = await UDBS.DeleteUserAsync(usr);
            bool b = bool.Parse(a.ToString());

        }

        private async void SendToInventoryTbl_Click(object sender, RoutedEventArgs e)
        {
            usr.Password = password.Text;
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(SentFrom);
        }
    }
}
