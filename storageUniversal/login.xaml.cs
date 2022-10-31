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
        public login()
        {
            this.InitializeComponent();
        }

        private async void SendEmailPass_Click(object sender, RoutedEventArgs e)
        {
            
            usr.Password = password.Text;
            usr.Email = email.Text;
            UserDBServ.IsUserPermittedResponse a = await  UDBS.IsUserPermittedAsync(usr);
            bool b = bool.Parse(a.Body.IsUserPermittedResult.ToString());
            if (b)
            { 
                res.Text = "user exists, data should be showen";
                UserDBServ.GetFullUserResponse TempFullUsr = await UDBS.GetFullUserAsync(usr);
                FullUser = TempFullUsr.Body.GetFullUserResult;
                this.Frame.Navigate(typeof(updateUser));
            }
            else {
                res.Text = "email or password are wrong, try again";
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
            UserDBServ.DeleteUserResponse a = await UDBS.DeleteUserAsync(usr);
            bool b = bool.Parse(a.Body.DeleteUserResult.ToString());

        }

        private async void SendToInventoryTbl_Click(object sender, RoutedEventArgs e)
        {
            usr.Password = password.Text;
            usr.Email = email.Text;
            UserDBServ.IsUserPermittedResponse a = await UDBS.IsUserPermittedAsync(usr);
            bool b = bool.Parse(a.Body.IsUserPermittedResult.ToString());
            if (b)
            {
                res.Text = "user exists, data should be showen";
                UserDBServ.GetFullUserResponse TempFullUsr = await UDBS.GetFullUserAsync(usr);
                FullUser = TempFullUsr.Body.GetFullUserResult;
                this.Frame.Navigate(typeof(InventoryView));
            }
            else
            {
                res.Text = "email or password are wrong, try again";
            }
        }
    }
}
