using System;
using System.Data;
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
using Windows.UI.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BrowwingsAndDistractions : Page
    {
        public static UserDBServ.User user;
        public static Type senderPage;
        public BrowwingsAndDistractions()
        {
            this.InitializeComponent();
            loadTbl();
            // some code to handle mouse back + forward buttons
            Window.Current.Activate();
            Window.Current.CoreWindow.PointerPressed += CoreWindow_PointerPressed;
        }
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
        //loads all the user's active borrowings and inserts them into ListView
        private async void loadTbl()
        {
            var BDB = new BorowwDb.BorowwingsDBSoapClient();
            var DataTbl = await BDB.GetLandingsAsync(user.ID);
            var borrows = new List<codes.Borrow>();
            foreach(DataRow dr in DataTbl.Rows)
            {
                var bro = new codes.Borrow();
                bro.ItemId = int.Parse(dr["ItemId"].ToString());
                bro.BorrowedBy = dr["BorrowedBy"].ToString();
                bro.When = DateTime.Parse(dr["When"].ToString());
                bro.Quantity = float.Parse(dr["Quantity"].ToString());
                bro.UserId = int.Parse(dr["UserId"].ToString());
                await bro.SetName(bro.ItemId);
                borrows.Add(bro);
            }
            LandsTbl.ItemsSource = borrows;
        }
        //takes you back to previos page
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
