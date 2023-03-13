using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal.visual_elements.content_dialog
{
    public sealed partial class ItemsInShortage : ContentDialog
    {

        public ObservableCollection<InventoryRow> ItemsList = new ObservableCollection<InventoryRow>();
        public static Type converter = typeof(storageUniversal.visual_elements.content_dialog.QuantityDifferenceConverter);
        public ItemsInShortage(ObservableCollection<InventoryRow> list)
        {
            this.InitializeComponent();
            foreach(var item in list)
            {
                if(item.NeededQuantity > item.Quantity)
                {
                    ItemsList.Add(item);
                }
            }
            DataContext = ItemsList;
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        public class QuantityDifferenceConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                return Math.Abs((value as InventoryRow).NeededQuantity - (value as InventoryRow).Quantity);
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
            {
                throw new NotImplementedException();


            }
        }
    }
}
