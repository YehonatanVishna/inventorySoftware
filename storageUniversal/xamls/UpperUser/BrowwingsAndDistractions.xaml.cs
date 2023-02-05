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
using System.Collections.ObjectModel;
using storageUniversal.xamls.UpperUser;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// This page allowes the user to menege his active landings
    /// </summary>
    public sealed partial class BrowwingsAndDistractions : Page
    {
        public static UserDBServ.User user;
        public static Type senderPage;
        //a collection of all the borrows binded in the table
        //אוסף של כל העצמים המוצגים בטבלה
        public static ObservableCollection<codes.Borrow> borrows = new ObservableCollection<codes.Borrow>();
        private List<codes.Borrow> borroesUnTouched = new List<codes.Borrow>();
        public BrowwingsAndDistractions()
        {
            this.InitializeComponent();
            loadTbl();
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
        //מעלה את כל ההשאלות הפעילות של המשתמש ומכניס אותם לטבלה
        //loads all the user's active borrowings and inserts them into ListView
        private async void loadTbl()
        {
            var BDB = new BorowwDb.BorowwingsDBSoapClient();
            var DataTbl = await BDB.GetLandingsAsync(user.ID);
            borrows.Clear();
            foreach(DataRow dr in DataTbl.Rows)
            {
                var bro = new codes.Borrow();
                bro.ItemId = int.Parse(dr["ItemId"].ToString());
                bro.BorrowedBy = dr["BorrowedBy"].ToString();
                bro.When = DateTime.Parse(dr["When"].ToString());
                bro.Quantity = float.Parse(dr["Quantity"].ToString());
                bro.UserId = int.Parse(dr["UserId"].ToString());
                bro.BorrowingId = int.Parse(dr["BorrowingId"].ToString());
                await bro.SetName(bro.ItemId);
                borrows.Add(bro);
            }
            foreach(codes.Borrow a in borrows)
            {
                borroesUnTouched.Add(a.copy());
            }
            LandsTbl.ItemsSource = borrows;
        }
        //מחזיר את המשתמש לעמוד הקודם
        //takes you back to previos page
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }
        private List<codes.Borrow> selectedItems = new List<codes.Borrow>();
        private void Grid_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            selectedItems.Clear();
            foreach (ItemIndexRange range in LandsTbl.SelectedRanges.ToList())
            {
                for(int i=range.FirstIndex; i<=range.LastIndex; i++)
                {
                    selectedItems.Add(LandsTbl.Items[i] as codes.Borrow);
                }
            }
            if (selectedItems.Count <= 0)
            {
                codes.Borrow clickedItem = new codes.Borrow();
                int borrowid = int.Parse(((sender as Grid).Children.Last() as TextBlock).Text);
                foreach (codes.Borrow a in LandsTbl.Items)
                {
                    if (a.BorrowingId == borrowid)
                    {
                        clickedItem = a;
                    }
                }
                LandsTbl.SelectedItem = clickedItem;
            }
                //LandsTbl.SelectRange(new ItemIndexRange(clickedIndex, 1));
                //clickedItem = LandsTbl.Items[LandsTbl.item] as InventoryRow;
                MenuFlyout rightClick = new MenuFlyout();
                var icon = new SymbolIcon() { Symbol = Symbol.Delete };
                MenuFlyoutItem deleteOption = new MenuFlyoutItem { Icon = icon, Text = "delete", FontFamily = new FontFamily("Segoe MDL2 Assets") };
                deleteOption.Click += DeleteOption_Click;
                rightClick.Items.Add(deleteOption);
                UIElement b = sender as UIElement;
                b.ContextFlyout = rightClick;
                Point point = new Point(e.GetPosition(b).X, e.GetPosition(b).Y);
                rightClick.ShowAt(b, point);
        }

        private async void DeleteOption_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Wait, 1);
            var BorServ = new BorowwDb.BorowwingsDBSoapClient();
            foreach(codes.Borrow br in selectedItems)
            {
                var bs = new BorowwDb.Borrow() { BorrowingId = br.BorrowingId, BorrowedBy= br.BorrowedBy, ItemId = br.ItemId, Quantity = br.Quantity, UserId = br.UserId, When = br.When };
                var isok =await BorServ.DeleteLandingAsync(bs, user.Email, user.Password);
            }
            loadTbl();
            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Arrow, 1);

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            loadTbl();
        }

        private async void SyncButton_Click(object sender, RoutedEventArgs e)
        {
            syncToDataBase();
        }
        public BorowwDb.Borrow convert(codes.Borrow borrow)
        {
            return new BorowwDb.Borrow() { BorrowedBy = borrow.BorrowedBy, BorrowingId = borrow.BorrowingId, ItemId = borrow.ItemId, Quantity = borrow.Quantity, UserId = borrow.UserId, When = borrow.When};
        }
        public async void syncToDataBase()
        {
            Window.Current.CoreWindow.PointerCursor = new Windows.UI.Core.CoreCursor(Windows.UI.Core.CoreCursorType.Wait, 1);
            var bdb = new BorowwDb.BorowwingsDBSoapClient();
            for(int i=0; i<borrows.Count; i++)
            {
                var old = borroesUnTouched[i];
                await bdb.updateBorrowAsync(convert(old), convert(LandsTbl.Items[i] as codes.Borrow), user.Email, user.Password);
            }
            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Arrow, 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PendingOrders_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UpperSeeOrders));
        }
    }
}
