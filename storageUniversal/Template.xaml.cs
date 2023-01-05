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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace storageUniversal
{
    public sealed partial class Template : UserControl
    {
        public static readonly DependencyProperty PassTxt = DependencyProperty.Register("Password",typeof(String),typeof(Template), new PropertyMetadata(0));
        public Template()
        {
            this.InitializeComponent();
        }
        public static void SetPassword(UIElement element, String s)
        {
            element.SetValue(PassTxt, s);
        }
        public static String GetPassword(UIElement element)
        {
            return element.GetValue(PassTxt) as String;
        }

        private void Pass_FocusEngaged(Control sender, FocusEngagedEventArgs args)
        {
            pass.PasswordRevealMode = PasswordRevealMode.Visible;
        }

        private void Pass_FocusDisengaged(Control sender, FocusDisengagedEventArgs args)
        {
            pass.PasswordRevealMode = PasswordRevealMode.Hidden;
        }

        private void Pass_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
