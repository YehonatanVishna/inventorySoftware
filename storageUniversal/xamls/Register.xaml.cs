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

        }
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
        //checks whether the email alredy axists in db
        public async Task<bool> DoesEmailExistAlready(string email)
        {
            var UDBS = new UserDBServ.UserDBServSoapClient();
            return await UDBS.DoesEmailExistAsync(email);
        }
        //responds to click on register button, registers user
        private async void RegBot_Click(object sender, RoutedEventArgs e)
        {
            UserDBServ.UserDBServSoapClient UDBS = new UserDBServ.UserDBServSoapClient();
            UserDBServ.User usr = new UserDBServ.User();
            if (!isEmailValid(email.Text)) {
                IsEmailValidBlock.Text = "email is not valid";
                return;
            }
            bool exists = await DoesEmailExistAlready(email.Text);
            if (exists)
            {
                IsEmailValidBlock.Text = "user with this email already exists, use another email adress"; return;
            }
            
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
        //go back to previus page
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(SentFrom);
        }
    }
}
