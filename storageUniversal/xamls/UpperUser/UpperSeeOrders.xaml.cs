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
using System.Collections.ObjectModel;
using System.Data;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal.xamls.UpperUser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpperSeeOrders : Page
    {
        public static ObservableCollection<SubUserServ.Order> UnAprovedBindedOrders = new ObservableCollection<SubUserServ.Order>();
        public static ObservableCollection<SubUserServ.Order> AprovedBindedOrders = new ObservableCollection<SubUserServ.Order>();
        private List<SubUserServ.Order> orders = new List<SubUserServ.Order>();
        public UpperSeeOrders()
        {
            this.InitializeComponent();
            LoadTables();
        }
        public SubUserServ.User FullUpperUserFromSubServ
        {
            get
            {
                return new SubUserServ.User() { ID = UpperLogin.FullUser.ID, BDate = UpperLogin.FullUser.BDate, Compeny = UpperLogin.FullUser.Compeny, Email = UpperLogin.FullUser.Email, Fname = UpperLogin.FullUser.Fname, Lname = UpperLogin.FullUser.Lname, Password = UpperLogin.FullUser.Password };
            }
        }
        public async void LoadTables()
        {
            var serv = new UserDBServ.UserDBServSoapClient();
            var tbldata = await serv.getUpperOrdersAsync(UpperLogin.FullUser);
            orders.Clear();
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
                if (DateTime.TryParse(row["OrderDate"].ToString(), out DateTime OrderDate))
                {
                    order.OrderDate = OrderDate;
                }

                orders.Add(order);
            }
            AprovedBindedOrders.Clear();
            UnAprovedBindedOrders.Clear();
            foreach(var order in orders)
            {
                if (!order.Rejected) { 
                    if (order.Aproved)
                    {
                        AprovedBindedOrders.Add(order);
                    }
                    else
                    {
                        UnAprovedBindedOrders.Add(order);
                    }
                }

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

        private async void AcceptOrder_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var order = btn.DataContext as SubUserServ.Order;
            order.Aproved = true;
            var serv = new SubUserServ.SubUsersServSoapClient();
            bool a = await serv.UpdateOrderByUpperUserAsync(FullUpperUserFromSubServ, order);
            UnAprovedBindedOrders.Remove(order);
            AprovedBindedOrders.Add(order);

        }

        private async void RejectOrder_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var order = btn.DataContext as SubUserServ.Order;
            order.Rejected = true;
            var serv = new SubUserServ.SubUsersServSoapClient();
            bool a = await serv.UpdateOrderByUpperUserAsync(FullUpperUserFromSubServ, order);
            UnAprovedBindedOrders.Remove(order);
        }

        private async void AddAllAprovedToBorrowings_Click(object sender, RoutedEventArgs e)
        {
            var borowwServ = new BorowwDb.BorowwingsDBSoapClient();
            var SubServ = new SubUserServ.SubUsersServSoapClient();
            foreach(var order in AprovedBindedOrders)
            {
                var borrower = await SubServ.GetYourSubUserAsync(FullUpperUserFromSubServ, order.BySubUser);
                int borrowing_ID = await borowwServ.AddLendingAsync(order.ItemId,borrower.FName + " " + borrower.LName, DateTime.Now, order.Amount, UpperLogin.FullUser.ID);
                borowwServ.UpdateAmountOutAsync(order.ItemId);
            }
            AprovedBindedOrders.Clear();
        }
    }


}
