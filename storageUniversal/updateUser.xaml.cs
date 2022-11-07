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

//made by yehonatan vishna
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class updateUser : Page
    {
        private UserDBServ.UserDBServSoapClient UDBS = new UserDBServ.UserDBServSoapClient();
        public static UserDBServ.User FullUser = login.FullUser;
        public updateUser()
        {
            this.InitializeComponent();
            FN.Text = FullUser.Fname;
            LN.Text = FullUser.Lname;
            newemail.Text = FullUser.Email;
            DateTime time = FullUser.BDate;
            BDate.Date = time.Date;
            compeny.Text = FullUser.Compeny;
            pass.Text = FullUser.Password;
        }
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
        }
    }
