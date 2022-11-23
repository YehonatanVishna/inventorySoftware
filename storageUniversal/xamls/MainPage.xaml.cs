using System;
using System.IO;
using System.Text.RegularExpressions;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Net;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace storageUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            tt.Text = Dns.GetHostName() ;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            login.SentFrom = "MainPage";
            this.Frame.Navigate(typeof(login));
        }

        private void Logon_Click(object sender, RoutedEventArgs e)
        {
            Register.SentFrom = "MainPage";
            Frame.Navigate(typeof(Register));
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InventoryView));
        }
    }
}
