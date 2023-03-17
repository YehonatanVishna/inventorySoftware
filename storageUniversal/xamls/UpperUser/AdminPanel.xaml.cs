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
using System.Xml;
using System.Data;
using Windows.UI.Core;
using System.Collections.ObjectModel;
using storageUniversal.codes;
using storageUniversal.xamls.UpperUser;
using storageUniversal.xamls;
using Microsoft.Toolkit.Uwp.UI.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// This is a page for the admin to update the personal detailes of all existing users
    /// </summary>
    public sealed partial class AdminPanel : Page
    {
        //משתנה המכיל את פרטי ההתחברות של המנהל
        //the admin user
        public UserDBServ.User AdminUser = UpperLogin.FullUser;

        public static Type SentFrom { get; internal set; }

        //רשימה המכילה את כל המשתמשים כפי שהיו אחרי העדכון האחרון
        //user list as it is in the last refresh
        public List<User> UsersOriginal;
        //רשימה של כל המשתמשים כפי שהם כעת בטבלה
        //users as they are after the changes the user made
        public ObservableCollection<User> BinedUsersInTbl = new ObservableCollection<User>();
        public AdminPanel()
        {
            this.InitializeComponent();
            var hov = new addHoverControlElement(Apply as ContentControl, "apply changes made to users to db");
            loudTbl();
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
        //מכניס את כל המשתמשים במערכת לטבלה
        //loads all users from db and inserts them to the table (ListView)
        public async void loudTbl()
        {
            UserDBServ.UserDBServSoapClient s = new UserDBServ.UserDBServSoapClient();
            var r = await s.GetAdminUserTblAsync(AdminUser);
            List<User> Users = new List<User>();
            foreach(DataRow a in r.Rows)
            {
                User row = new User();
                row.ID = int.Parse(a["ID"].ToString());
                row.Fname = a["FName"].ToString();
                row.Lname = a["LName"].ToString();
                row.Email = a["email"].ToString();
                row.BDate = DateTime.Parse(a["BDate"].ToString());
                row.Compeny = a["compeny"].ToString();
                row.Password = a["password"].ToString();
                Users.Add(row);
            }
            if(BinedUsersInTbl.ToList().Count > 0) { 
                BinedUsersInTbl.Clear();
            }
            foreach (User row in Users)
            {
                BinedUsersInTbl.Add(row);
            }
            UsersTbl.ItemsSource = BinedUsersInTbl;
            UsersOriginal = new List<User>();
            foreach (User Row in Users)
            {
                
                UsersOriginal.Add(Row.copy());
            }

        }
        ContentDialog changesApplyed = new ContentDialog()
        {
            Title = "Sucsess",
            Content = "The changes to users info where sucsussfully commited to database",
            CloseButtonText = "Ok"
        };
        //converts local User type To User type in web service
        public UserDBServ.User LocalUserToWebUser(User user)
        {
            UserDBServ.User NewUser = new UserDBServ.User();
            NewUser.ID = user.ID;
            NewUser.Fname = user.Fname;
            NewUser.Lname = user.Lname;
            NewUser.Compeny = user.Compeny;
            NewUser.Email = user.Email;
            if (user.BDate == null)
            {
                NewUser.BDate = DateTime.Parse(DateTimeOffset.MinValue.ToString());
            }
            else
            {
                NewUser.BDate = user.BDate;
            }
            NewUser.Password = user.Password;
            return NewUser;
        }
        //בלחיצה על כפתור העידכון, מעדכן את פרטי המשתמשים במסד נתונים לפי השינויים שעשה המנהל
        //a code for applying changes admin made to User's ditailes in db
        private async void Apply_Click(object sender, RoutedEventArgs e)
        {
            UserDBServ.UserDBServSoapClient s = new UserDBServ.UserDBServSoapClient();
            var CurrentUsers = UsersTbl.Items;
            bool IsAllOk = true;
            foreach (User user in CurrentUsers)
            {
                foreach (User OgUsr in UsersOriginal)
                {
                    if (OgUsr.ID == user.ID)
                    {
                        if (!OgUsr.IsSame(user))
                        {
                            UserDBServ.User NewUser = LocalUserToWebUser(user);
                            UserDBServ.User OldUser = LocalUserToWebUser(OgUsr);
                            bool hadWorked = await s.updateUserByIdAdminAsync(user.ID, AdminUser, NewUser);
                            IsAllOk = IsAllOk && hadWorked;
                        }
                    }
                }
            }
            if (IsAllOk)
            {
                await changesApplyed.ShowAsync();
            }

        }
        //בחיצה על הכפור, מוסיף לטבלה ולמסד הנתונים משתמש ריק
        //code to add a new row representing new user in tbl
        private async void AddUser_Click(object sender, RoutedEventArgs e)
        {
            UserDBServ.UserDBServSoapClient s = new UserDBServ.UserDBServSoapClient();
            User NewUser = new User();
            var id = await s.AddEmptyUserAsync();
            NewUser.ID = id;
            BinedUsersInTbl.Add(NewUser);
            UsersOriginal.Add(NewUser);
        }
        //בלחיצה על כפתור המחיקה מוחק את המשתמש המסומן
        //code for deleting selected user from table and db
        private async void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            int SelIn = UsersTbl.SelectedIndex;
            User SelectedUser = UsersTbl.Items[SelIn] as User;
            int id = SelectedUser.ID;
            UserDBServ.UserDBServSoapClient r = new UserDBServ.UserDBServSoapClient();
            bool hasWorked = await r.DeleteUserAdminAsync(AdminUser,id);
            BinedUsersInTbl.Remove(SelectedUser);
        }
        //מחזיר את המשתמש למסך הקודם בלחיצה על כפתור החזרה
        //back button click
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }
        //מגיב ללחיצה על כפתור הריענון
        //respondes to click on refresh button
        private void RefreshBut_Click(object sender, RoutedEventArgs e)
        {
            loudTbl();
        }
        //מעלה תפריט קליק ימני
        private void Gridy_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            UsersTbl.SelectedItem = (sender as Grid).DataContext;
            if (UsersTbl.SelectedItem != null)
            {
                var right_click_menu = new MenuFlyout();
                var see_subUsers_option = new MenuFlyoutItem() { Text = "see sub users" };
                see_subUsers_option.DataContext = UsersTbl.SelectedItem;
                see_subUsers_option.Click += See_subUsers_option_ClickAsync;
                right_click_menu.Items.Add(see_subUsers_option);
                right_click_menu.ShowAt(sender as Grid, e.GetPosition(sender as Grid));
            }
            

        }

        private async void See_subUsers_option_ClickAsync(object sender, RoutedEventArgs e)
        {
            var user = (sender as MenuFlyoutItem).DataContext as User;
            var server_user= new SubUserServ.User() { ID = user.ID, BDate = user.BDate, Compeny = user.Compeny, Email = user.Email, Fname = user.Fname, Lname = user.Lname, Password = user.Password };
            //יוצר הודעה עם כל המשתמשים
            var subUsers_popup = new ContentDialog() { Title = "The Sub Users That Belongs To User " + user.ID, CloseButtonText = "ok" };
            var viewBox = new Viewbox();
            var subs_grid = new DataGrid() { IsReadOnly = true};
            var SubUsers_soap_client = new SubUserServ.SubUsersServSoapClient();
            DataTable r;
            try
            {
                r = await SubUsers_soap_client.getYourSubUsersAsync(server_user);
            }
            catch
            {
                r = new DataTable();
            }
            List<SubUser> Users = new List<SubUser>();
            foreach (DataRow a in r.Rows)
            {
                SubUser row = new SubUser();
                row.Id = int.Parse(a["ID"].ToString());
                row.FName = a["FName"].ToString();
                row.LName = a["LName"].ToString();
                row.Email = a["Email"].ToString();
                row.BelongsToUpperUser = int.Parse(a["BelongsToUpperUser"].ToString());
                row.Role = a["Role"].ToString();
                row.Password = a["Password"].ToString();
                row.UserName = a["UserName"].ToString();
                Users.Add(row);
            }
            subs_grid.ItemsSource = Users;
            viewBox.Child = subs_grid;
            subUsers_popup.Content = viewBox;
            await subUsers_popup.ShowAsync();
        }
    }
}


