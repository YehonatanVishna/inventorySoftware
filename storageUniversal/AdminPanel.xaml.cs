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
using System.Xml;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace storageUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPanel : Page
    {
        public UserDBServ.User AdminUser = login.FullUser;
        public List<User> UsersOriginal;
        public AdminPanel()
        {
            this.InitializeComponent();
            loudTbl();

        }
        public async void loudTbl()
        {
            UserDBServ.UserDBServSoapClient s = new UserDBServ.UserDBServSoapClient();
            var r = await s.GetAdminUserTblAsync(AdminUser);
            List<User> Users = new List<User>();
            User row = null;
            XmlReader xr = r.Any1.CreateReader();
            XmlDocument document = new XmlDocument();
            document.Load(xr);
            XmlNodeList xml_items_list = document.GetElementsByTagName("Users");
            foreach (XmlElement item in xml_items_list)
            {
                row = new User();
                foreach (XmlNode node in item.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "FName": row.Fname = node.InnerText.ToString(); break;
                        case "ID": row.ID = int.Parse(node.InnerText); break;
                        case "LName": row.Lname = node.InnerText; break;
                        case "BDate": row.BDate = DateTime.Parse(node.InnerText.ToString()); break;
                        case "compeny": row.Compeny = node.InnerText; break;
                        case "email": row.Email = node.InnerText; break;
                        case "password": row.Password = node.InnerText; break;
                    }
                }
                Users.Add(row);

            }
            UsersTbl.ItemsSource = Users;
            UsersOriginal = new List<User>();
            foreach (User Row in Users)
            {
                UsersOriginal.Add(Row.copy());
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

    }
    public class DateTimeToDateTimeOffsetConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DateTimeOffset dt;
            if (value != null && value is DateTime)
            {
                String stringToConvert = value.ToString();
                if (!DateTimeOffset.TryParse(stringToConvert, out dt))
                {
                    return null;
                }
            }
            return dt;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            DateTime time;
            if (value != null && value is DateTimeOffset)
            {
                var valueToConvert = (DateTimeOffset)value;
                time = new DateTime(valueToConvert.Ticks);
            }
            else
            {
                return null;
            }
            return time;
        }
    }

