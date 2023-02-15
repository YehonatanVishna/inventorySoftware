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
using storageUniversal.xamls.LowerUser;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal.xamls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LowerLogin : Page
    {
        public static SubUserServ.SubUser FullSubUser;
        public bool navingate;
        public static Type sender;
        //פעולה ששולחת משתמש שכבר נכנס לעמוד הבית שלו
        public async void gotoHome()
        {
            await Task.Delay(1);
            Frame.Navigate(typeof(LowerUserHome));
        }

        public LowerLogin()
        {
            this.InitializeComponent();
            var f = Frame;
            var frame = Window.Current.Content as Frame;
            var c = frame.SourcePageType;
            if (c == typeof(MainPage))
            {
                //מעביר אוטומטית לעמוד הבא אם המשתמש כבר מחובר
                if (FullSubUser == null)
                {
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
                else
                {
                    gotoHome();
                }
            }

        }
        //פקודה שמכניסה משתמש שפרטיו שמורים במערכת
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
                log(tempSub, parameter as storageUniversal.xamls.LowerLogin);

            }
        }
        //מכניס את המשתמש למערכת בעזרת הפרטים השמורים
        public async static void log(SubUserServ.SubUser tempSub, storageUniversal.xamls.LowerLogin frame)
        {
            var serv = new SubUserServ.SubUsersServSoapClient();
            FullSubUser = await serv.GetFullUserAsync(tempSub);
            if (FullSubUser != null)
            {
                
                var sucsuss = new ContentDialog() { Title = "hello " + FullSubUser.FName + " " + FullSubUser.LName, CloseButtonText = "ok" };
                await sucsuss.ShowAsync();
                frame.Frame.Navigate(typeof(LowerUserHome));

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
        //מבצע כניסה ואימות פרטים אחרי שהמשתמש הכניס פרטים ולחץ על כפתור ההתחברות
        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (FullSubUser != null)
            {
                Frame.Navigate(typeof(LowerUserHome));
                return;
            }
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
                Frame.Navigate(typeof(LowerUserHome));
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
        //שוכח את פרטי המשתמש אם החליט גם לשכוח את כל מה שנשמר בצורה קבועה אז מוחק גם את זה
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            FullSubUser = null;
            if (forget_saved_users.IsChecked.GetValueOrDefault())
            {
                Windows.Storage.ApplicationData.Current.LocalSettings.Values["Is_SubUser_saved"] = false.ToString();
                Windows.Storage.ApplicationData.Current.LocalSettings.Values["Sub_UserName"] = "";
                Windows.Storage.ApplicationData.Current.LocalSettings.Values["Sub_Password"] = "";
            }
        }
    }
}
