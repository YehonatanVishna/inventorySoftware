using storageUniversal;
using System;
using Windows.UI.Xaml.Data;
namespace storageUniversal.visual_elements.content_dialog
{ 
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