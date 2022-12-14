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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPanel : Page
    {
        //the admin user
        public UserDBServ.User AdminUser = login.FullUser;
        //user list as it is in the last refresh
        public List<User> UsersOriginal;
        //users as they are after the changes the user made
        public List<User> UsersInTbl;
        //the page to return to after clicking back button
        public static Type SentFrom;
        public AdminPanel()
        {
            this.InitializeComponent();
            UsersTbl.Margin = new Thickness(0, back.Height, 0, 0);
            loudTbl();

        }
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
            UsersTbl.ItemsSource = Users;
            UsersInTbl = Users;
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
        //code to add a new row representing new user in tbl
        private async void AddUser_Click(object sender, RoutedEventArgs e)
        {
            UserDBServ.UserDBServSoapClient s = new UserDBServ.UserDBServSoapClient();
            User NewUser = new User();
            var id = await s.AddEmptyUserAsync();
            NewUser.ID = id;
            UsersInTbl.Add(NewUser);
            UsersOriginal.Add(NewUser);
            UsersTbl.ItemsSource = null;
            UsersTbl.ItemsSource = UsersInTbl;
        }
        //code for deleting selected user from table and db
        private async void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            int SelIn = UsersTbl.SelectedIndex;
            User SelectedUser = UsersTbl.Items[SelIn] as User;
            int id = SelectedUser.ID;
            UserDBServ.UserDBServSoapClient r = new UserDBServ.UserDBServSoapClient();
            bool hasWorked = await r.DeleteUserAdminAsync(AdminUser,id);
            UsersTbl.ItemsSource = null;
            loudTbl();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(SentFrom);
        }
    }
}


