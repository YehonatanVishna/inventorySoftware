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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        public static string SentFrom;
        public Register()
        {
            this.InitializeComponent();

        }
        private async void RegBot_Click(object sender, RoutedEventArgs e)
        {
            UserDBServ.UserDBServSoapClient UDBS = new UserDBServ.UserDBServSoapClient();
            UserDBServ.User usr = new UserDBServ.User();
            var date = BDate.Date;
            DateTime time = date.Value.DateTime;
            usr.BDate = time;
            usr.Fname = FN.Text;
            usr.Lname = LN.Text;
            usr.Email = email.Text;
            usr.Password = pass.Text;
            usr.Compeny = compeny.Text;
            var a = await UDBS.regAsync(usr);
            bool IsSuccess = bool.Parse(a.ToString());
            if (IsSuccess)
            {
                isDone.Text = "logon is successfull";
                //Thread.Sleep(66);
                
                Frame.Navigate(typeof(MainPage));
            }
            else
            {
                isDone.Text = "logon is unsuccessfull, try again";
            }


        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            switch (SentFrom)
            {
                case "login": Frame.Navigate(typeof(login)); break;
                case "Register": Frame.Navigate(typeof(Register)); break;
                case "InventoryView": Frame.Navigate(typeof(InventoryView)); break;
                case "AdminPanel": Frame.Navigate(typeof(AdminPanel)); break;
                case "updateUser": Frame.Navigate(typeof(updateUser)); break;
                case "MainPage": Frame.Navigate(typeof(MainPage)); break;
            }
        }
    }
}
