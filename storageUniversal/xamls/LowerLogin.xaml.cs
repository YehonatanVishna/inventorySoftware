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
using Windows.Storage;
using System.Windows.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal.xamls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LowerLogin : Page
    {
        public static SubUserServ.SubUser FullSubUser;
        public LowerLogin()
        {
            this.InitializeComponent();
            //שואל את המשתמש אם הוא רוצה להשתמש במשתמש שמור
            if (Windows.Storage.ApplicationData.Current.LocalSettings.Values["Is_SubUser_saved"] != null && bool.Parse(Windows.Storage.ApplicationData.Current.LocalSettings.Values["Is_SubUser_saved"] as string))
            {
                ContentDialog getLandingDits = new ContentDialog()
                {
                    Title = "do you wish to use saved user?",
                    SecondaryButtonText = "yes",
                    SecondaryButtonCommand = new logSavedUser(),
                    SecondaryButtonCommandParameter = this,
                    CloseButtonText = "no"
                };
                getLandingDits.ShowAsync();
            }
        }
        private class logSavedUser : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            public async void Execute(object parameter)
            {
                ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                var tempSub = new SubUserServ.SubUser();
                tempSub.Password = localSettings.Values["Sub_Password"] as string;
                tempSub.UserName = localSettings.Values["Sub_UserName"] as string;
                log(tempSub, parameter as LowerUserOrdePage);

            }
        }
        public async static void log(SubUserServ.SubUser tempSub, LowerUserOrdePage page)
        {
            var serv = new SubUserServ.SubUsersServSoapClient();
            FullSubUser = await serv.GetFullUserAsync(tempSub);
            if (FullSubUser != null)
            {
                var sucsuss = new ContentDialog() { Title = "hello " + FullSubUser.FName + " " + FullSubUser.LName, CloseButtonText = "ok" };
                await sucsuss.ShowAsync();
                page.Frame.Navigate(typeof(LowerUserOrdePage));

            }
            else
            {
                var fail = new ContentDialog() { Title = "your login had failed, please try again", CloseButtonText = "ok" };
                await fail.ShowAsync();
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

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var tempSub = new SubUserServ.SubUser();
            tempSub.Password = password.Password;
            tempSub.UserName = UserNameInput.Text;
            var serv = new SubUserServ.SubUsersServSoapClient();
            FullSubUser = await serv.GetFullUserAsync(tempSub);
            if(FullSubUser != null)
            {
                var sucsuss = new ContentDialog() { Title = "hello " + FullSubUser.FName + " " + FullSubUser.LName, CloseButtonText= "ok"};
                await sucsuss.ShowAsync();
                if (rememberBox.IsChecked.GetValueOrDefault())
                {
                    ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                    // Save a setting locally on the device
                    localSettings.Values["Sub_UserName"] = FullSubUser.UserName;
                    localSettings.Values["Sub_Password"] = FullSubUser.Password;
                    localSettings.Values["Is_SubUser_saved"] = true.ToString();
                }
            }
            else
            {
                var fail = new ContentDialog() { Title = "your login had failed, please try again", CloseButtonText = "ok" };
                await fail.ShowAsync();
            }
        }

        private void Res_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


    }
}
