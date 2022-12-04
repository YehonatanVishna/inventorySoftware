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
using System.Data;
using System.Xml;
using storageUniversal;
using System.Text.RegularExpressions;
using System.Windows.Input;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InventoryView : Page
    {
        public List<InventoryRow> inventories;// original inventory
        public List<InventoryRow> currentInventories;
        public static UserDBServ.User FullUser = login.FullUser;
        public static Type SentFrom;
        public static InventoryRow LantItem;
        public InventoryView()
        {
            this.InitializeComponent();
            LoadTblFunc();
        }

        private void InventoryTbl_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private void LoadTbl_Click(object sender, RoutedEventArgs e)
        {
            LoadTblFunc();
        }
        private async void LoadTblFunc()
        {
            InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
            InventoryServ.GetInventoryUserDataTableResponseGetInventoryUserDataTableResult r = await s.GetInventoryUserDataTableAsync(FullUser.ID);
            List<InventoryRow> inventoryRows = new List<InventoryRow>();
            InventoryRow row = null;
            XmlReader xr = r.Any1.CreateReader();
            XmlDocument document = new XmlDocument();
            document.Load(xr);
            XmlNodeList xml_items_list = document.GetElementsByTagName("inventory");
            foreach (XmlElement item in xml_items_list)
            {
                row = new InventoryRow();
                foreach (XmlNode node in item.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "Name": row.Name = node.InnerText.ToString(); break;
                        case "ID": row.ID = int.Parse(node.InnerText); break;
                        case "Quantity": row.Quantity = float.Parse(node.InnerText); break;
                        case "NeededQuantity": row.NeededQuantity = float.Parse(node.InnerText); break;
                        case "Remarkes": row.Remarkes = node.InnerText; break;
                        case "AmountOut": row.AmountOut = float.Parse(node.InnerText); break;
                    }
                }
                inventoryRows.Add(row);

            }
            InventoryTbl.ItemsSource = inventoryRows;
            inventories = new List<InventoryRow>();
            foreach (InventoryRow Row in inventoryRows)
            {
                inventories.Add(Row.copy());
            }
            currentInventories = inventoryRows;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void UpdateDataFromTbl_Click(object sender, RoutedEventArgs e)
        {
            UpdateDataToDB();
        }
        private async void UpdateDataToDB()
        {
            InventoryRow sel = (InventoryRow)InventoryTbl.SelectedItem;
            ItemCollection ic = InventoryTbl.Items;
            List<InventoryRow> inventoryRows = new List<InventoryRow>();
            int len = 0;
            foreach (InventoryRow a in ic)
            {
                len++;
                InventoryRow ro = new InventoryRow();
                ro.Name = a.Name;
                ro.Quantity = a.Quantity;
                ro.NeededQuantity = a.NeededQuantity;
                ro.ID = a.ID;
                ro.Remarkes = a.Remarkes;
                inventoryRows.Add(ro);
            }

            foreach (InventoryRow a in inventoryRows)
            {
                InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
                foreach (InventoryRow original in inventories)
                {
                    if (a.ID == original.ID)
                    {

                        if (a.Equal(original))
                        {
                            break;
                        }
                        else
                        {
                            InventoryServ.InventoryRow row = new InventoryServ.InventoryRow();
                            row.ID = a.ID;
                            row.Name = a.Name;
                            row.Quantity = a.Quantity;
                            row.NeededQuantity = a.NeededQuantity;
                            row.Remarkes = a.Remarkes;
                            bool isOk = await s.changeInventoryRowAsync(row);
                        }
                    }
                }

            }
        }

        private async void Delete_Click(object sender, RoutedEventArgs e)
        {
            InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
            int index = InventoryTbl.SelectedIndex;
            int id = ((InventoryRow)InventoryTbl.Items[index]).ID;
            bool res = await s.DeleteInventoryRowAsync(id);
            LoadTblFunc();
        }

        private async void AddItem_Click(object sender, RoutedEventArgs e)
        {
            InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
            InventoryRow NewRow = new InventoryRow();
            var ItemId = await s.getNewItemIdAsync(FullUser.ID);
            NewRow.ID = int.Parse(ItemId.ToString());
            NewRow.OwnerUserId = FullUser.ID;
            currentInventories.Add(NewRow);
            InventoryTbl.ItemsSource = null;
            InventoryTbl.ItemsSource = currentInventories;
            inventories.Add(NewRow.copy());

        }
        private async void addItemFunc(InventoryRow a)
        {
            InventoryServ.InventoryFuncsSoapClient s = new InventoryServ.InventoryFuncsSoapClient();
            InventoryRow NewRow = a;
            var ItemId = await s.getNewItemIdAsync(FullUser.ID);
            NewRow.ID = int.Parse(ItemId.ToString());
            NewRow.OwnerUserId = FullUser.ID;
            currentInventories.Add(NewRow);
            InventoryTbl.ItemsSource = null;
            InventoryTbl.ItemsSource = currentInventories;
            inventories.Add(NewRow.copy());
        }

        private async void CsvImport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var picker = new Windows.Storage.Pickers.FileOpenPicker();
                picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
                picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                picker.FileTypeFilter.Add(".csv");
                Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
                var randomAccessStream = await file.OpenReadAsync();
                Stream stream = randomAccessStream.AsStreamForRead();
                StreamReader reader = new StreamReader(stream);
                List<InventoryRow> inventoryRows = new List<InventoryRow>();
                using (reader)
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        //define pattern
                        Regex csvparser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                        //separating columns to array
                        string[] x = csvparser.Split(line);

                        /* do something with x */
                        InventoryRow row = new InventoryRow();
                        row.Name = x[0];
                        row.Quantity = float.Parse(x[1]);
                        row.NeededQuantity = float.Parse(x[2]);
                        row.Remarkes = x[3];
                        row.OwnerUserId = FullUser.ID;
                        inventoryRows.Add(row);
                    }
                }
                foreach (InventoryRow row in inventoryRows)
                {
                    addItemFunc(row);
                }

                //string text = await Windows.Storage.FileIO.ReadTextAsync(file);
                UpdateDataToDB();
            }
            catch { }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(SentFrom);
        }

        private async void LandButton_Click(object sender, RoutedEventArgs e)
        {
            Grid grid = new Grid();
            var rowDefinitions = grid.RowDefinitions;
            int i = 2;
            for(int j=0; j<i; j++)
            {
                rowDefinitions.Add(new RowDefinition());
            }
            TextBox amount = new TextBox { PlaceholderText = "amount" };
            Grid.SetRow(amount, 0); grid.Children.Add(amount); 
            TextBox lentTo = new TextBox { PlaceholderText = "Lent to" };
            Grid.SetRow(lentTo, 1); grid.Children.Add(lentTo);
            ContentDialog getLandingDits = new ContentDialog()
            {
                Title = "please fill out the landing ditails",
                Content = grid,
                SecondaryButtonText = "save",
                SecondaryButtonCommandParameter= grid, SecondaryButtonCommand=new saveBtnCmd(),
                CloseButtonText = "cancel"
            };
            getLandingDits.KeyDown += GetLandingDits_KeyDown;
            lentTo.KeyDown += GetLandingDits_KeyDown;
            await getLandingDits.ShowAsync();
        }

        private async void GetLandingDits_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            //if(e.Key.ToString().Equals("Enter"))
            //{
            //    if (sender is ContentDialog)
            //    {
            //        new saveBtnCmd().Execute((sender as ContentDialog).Content);
            //        (sender as ContentDialog).Hide();
            //    }
            //    if(sender is TextBox)
            //        new saveBtnCmd().Execute((sender as TextBox).Parent);
            //}
        }

        private void Gridy_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            if (InventoryTbl.SelectedItem != null)
            {
                LantItem = InventoryTbl.Items[InventoryTbl.SelectedIndex] as InventoryRow;
                MenuFlyout rightClick = new MenuFlyout();
                MenuFlyoutItem firstItem = new MenuFlyoutItem { Text = "land out" };
                firstItem.Click += LandButton_Click;
                rightClick.Items.Add(firstItem);
                UIElement b = sender as UIElement;
                b.ContextFlyout = rightClick;
                Point point = new Point(e.GetPosition(b).X, e.GetPosition(b).Y);
                rightClick.ShowAt(b, point);
            }


        }
        class saveBtnCmd : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            public async void Execute(object parameter)
            {
                UIElement content = parameter as UIElement;
                float amount = float.Parse(((content as Grid).Children[0] as TextBox).Text);
                string lentTo = ((content as Grid).Children[1] as TextBox).Text;
                var s = new BorowwDb.BorowwingsDBSoapClient();
                var id = await s.AddLendingAsync(LantItem.ID, lentTo, DateTime.Now, amount, FullUser.ID);
                var b = s.UpdateAmountOutAsync(LantItem.ID);
            }
        }

        private void SeeLandings_Click(object sender, RoutedEventArgs e)
        {
            BrowwingsAndDistractions.user = FullUser;
            BrowwingsAndDistractions.senderPage = typeof(InventoryView);
            Frame.Navigate(typeof(BrowwingsAndDistractions));
        }
    }
}
