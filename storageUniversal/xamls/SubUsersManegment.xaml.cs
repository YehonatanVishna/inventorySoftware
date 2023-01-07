using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace storageUniversal.xamls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SubUsersManegment : Page
    {
        //רשימה המכילה את כל המשתמשים כפי שהיו אחרי העדכון האחרון
        //user list as it is in the last refresh
        private List<SubUser> UsersOriginal;
        //רשימה של כל המשתמשים כפי שהם כעת בטבלה
        //users as they are after the changes the user made
        private ObservableCollection<SubUser> BinedUsersInTbl = new ObservableCollection<SubUser>();
        public SubUsersManegment()
        {
            this.InitializeComponent();
            loudTbl();
        }
        public async void LoadTbl()
        {
            loudTbl();
        }
        //מכניס את כל המשתמשים השייכים למשתמש זה לטבלה
        //loads all users's users from db and inserts them to the table (ListView)
        public async void loudTbl()
        {
            var s = new SubUserServ.SubUsersServSoapClient();
            var TmpUsr = login.FullUser;
            var usr = new SubUserServ.User() { ID = TmpUsr.ID, BDate = TmpUsr.BDate, Compeny = TmpUsr.Compeny, Email = TmpUsr.Email, Fname = TmpUsr.Fname, Lname = TmpUsr.Lname, Password = TmpUsr.Password };
            var r = await s.getYourSubUsersAsync(usr);
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
                Users.Add(row);
            }
            if (BinedUsersInTbl.ToList().Count > 0)
            {
                BinedUsersInTbl.Clear();
            }
            foreach (SubUser row in Users)
            {
                BinedUsersInTbl.Add(row);
            }
            SubUsersTbl.ItemsSource = BinedUsersInTbl;
            UsersOriginal = new List<SubUser>();
            foreach (SubUser Row in Users)
            {
                UsersOriginal.Add(Row.Copy());
            }
        }

        //send user back to previus page
        //כפתור אחורה- שולח את המשתמש לעמוד הקודם
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            addUserF();
        }
        private async void addUserF()
        {
            var sub = new SubUserServ.SubUsersServSoapClient();
            var usr = new SubUserServ.SubUser() { BelongsToUpperUser = login.FullUser.ID };
            var id = await sub.createSubUserAsync(usr, new SubUserServ.User() { Email = login.FullUser.Email, Password = login.FullUser.Password });
            var localUsr = new SubUser() { BelongsToUpperUser = login.FullUser.ID, Id = id };
            BinedUsersInTbl.Add(localUsr);
            UsersOriginal.Add(localUsr.Copy());
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            loudTbl();
        }

        private void Sync_Click(object sender, RoutedEventArgs e)
        {
            var s = new SubUserServ.SubUsersServSoapClient();
            for(int i=0; i< BinedUsersInTbl.Count; i++)
            {
                if (!BinedUsersInTbl.ToList()[i].IsSame(UsersOriginal[i]))
                {
                    s.updateSubAsync(conv(BinedUsersInTbl[i]), new SubUserServ.User() { Password = login.FullUser.Password, Email = login.FullUser.Email, ID = login.FullUser.ID });
                }
            }
        }

        private SubUserServ.SubUser conv(SubUser a)
        {
            return new SubUserServ.SubUser() { BelongsToUpperUser = a.BelongsToUpperUser, Email = a.Email, FName = a.FName, Id = a.Id, LName = a.LName, Password = a.Password, Role = a.Role };
        }
    }
}
