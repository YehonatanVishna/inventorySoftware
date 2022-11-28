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
            var BDB = new BorowwDb.BorowwingsDBSoapClient();
            LandsTbl.ItemsSource = BDB.GetLandingsAsync(user.ID);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(senderPage);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AmountLant_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            switch (e.Key.ToString())
            {
                case "Down": amountLant.Text = (float.Parse(amountLant.Text) - 1).ToString(); break;
                case "Up": amountLant.Text = (float.Parse(amountLant.Text) + 1).ToString(); break;
            }
        }
    }
}
