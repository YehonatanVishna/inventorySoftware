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

namespace storageUniversal.xamls.LowerUser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LowerSeeOrders : Page
    {
        public static ObservableCollection<SubUserServ.Order> BindedOrders = new ObservableCollection<SubUserServ.Order>();
        public LowerSeeOrders()
        {
            this.InitializeComponent();
            LoadTable();
            
            
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
        //מושך את המידע משירות הרשת וממלא את הטבלה
        public async void LoadTable()
        {
            var serv = new SubUserServ.SubUsersServSoapClient();
            var tbldata = await serv.getOrdersAsync(LowerLogin.FullSubUser);
            BindedOrders.Clear();
            foreach (DataRow row in tbldata.Rows)
            {
                var order = new SubUserServ.Order();
                order.ItemName = row["ItemName"].ToString();
                order.Amount = float.Parse(row["Amount"].ToString());
                order.ID = int.Parse(row["ID"].ToString());
                order.ItemId = int.Parse(row["ItemId"].ToString());
                order.BySubUser = int.Parse(row["BySubUser"].ToString());
                order.ToUpperUser = int.Parse(row["ToUpperUser"].ToString());
                order.Aproved = bool.Parse(row["Aproved"].ToString());
                order.Rejected = bool.Parse(row["Rejected"].ToString());
                order.Remarkes = row["Remarks"].ToString();
                if(DateTime.TryParse(row["OrderDate"].ToString(), out DateTime OrderDate))
                {
                    order.OrderDate = OrderDate;
                }
                string str;
                order.Status = getStatus(order);
                BindedOrders.Add(order);
            }

        }
        //לפי פרטי ההזמנה מחזיר משפט או צירוף שמתאר את מצב ההזמנה
        private string getStatus(SubUserServ.Order order)
        {
            var aproved = order.Aproved;
            var rejected = order.Rejected;
            if (aproved == false && rejected == false)
            {
                return "awaiting response";
            }
            else
            {
                if (aproved == false && rejected == true)
                {
                    return "rejected";
                }
                else
                {
                    if (aproved == true && rejected == false)
                    {
                        return "aproved";
                    }
                    else
                    {
                        return "error";
                    }
                }
            }
        }
    }
}
