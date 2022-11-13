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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPanel : Page
    {
        public UserDBServ.User AdminUser = login.FullUser;
        public List<User> UsersOriginal;
        public List<User> UsersInTbl;
        public AdminPanel()
        {
            this.InitializeComponent();
            loudTbl();

        }
        public async void loudTbl()
        {
            UserDBServ.UserDBServSoapClient s = new UserDBServ.UserDBServSoapClient();
            var r = await s.GetAdminUserTblAsync(AdminUser);
            List<User> Users = new List<User>();
            User row = null;
            XmlReader xr = r.Any1.CreateReader();
            XmlDocument document = new XmlDocument();
            document.Load(xr);
            XmlNodeList xml_items_list = document.GetElementsByTagName("Users");
            foreach (XmlElement item in xml_items_list)
            {
                row = new User();
                foreach (XmlNode node in item.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "FName": row.Fname = node.InnerText.ToString(); break;
                        case "ID": row.ID = int.Parse(node.InnerText); break;
                        case "LName": row.Lname = node.InnerText; break;
                        case "BDate": row.BDate = DateTime.Parse(node.InnerText.ToString()); break;
                        case "compeny": row.Compeny = node.InnerText; break;
                        case "email": row.Email = node.InnerText; break;
                        case "password": row.Password = node.InnerText; break;
                    }
                }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        ContentDialog changesApplyed = new ContentDialog()
        {
            Title = "Sucsess",
            Content = "The changes to users info where sucsussfully commited to database",
            CloseButtonText = "Ok"
        };
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
    }
}


