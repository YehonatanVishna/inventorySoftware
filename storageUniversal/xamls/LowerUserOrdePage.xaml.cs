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
    public sealed partial class LowerUserOrdePage : Page
    {
        private SubUserServ.SubUsersServSoapClient SubServ = new SubUserServ.SubUsersServSoapClient();
        private ObservableCollection<InventoryRow> BindedRowesInList = new ObservableCollection<InventoryRow>();
        public LowerUserOrdePage()
        {
            this.InitializeComponent();
            NamesList.ItemsSource = BindedRowesInList;
            LoadList();
        }
        //טוען את הטבלה על ידי לקיחת השמות ממסד הנתונים והשמתם במשתנה הטבלה
        private async void LoadList()
        {

            var dt = await SubServ.getLimitedSubUserInventoryListAsync(LowerLogin.FullSubUser);
            //var LimitedInventoryList = new List<InventoryRow>();
            BindedRowesInList.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                string Name = dr["Name"].ToString();
                int Id = int.Parse(dr["ID"].ToString());
                BindedRowesInList.Add(new InventoryRow() { Name = Name, ID = Id });
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
    }
}
