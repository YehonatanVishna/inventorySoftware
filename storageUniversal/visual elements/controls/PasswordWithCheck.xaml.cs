﻿using System;
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
    public sealed partial class PasswordWithCheck : UserControl
    {
        public PasswordWithCheck()
        {
            this.InitializeComponent();
        }
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        public string placeHolder
        {
            get => (string)GetValue(PlaceHolderProp);
            set => SetValue(PlaceHolderProp, value);
        }
        public static readonly DependencyProperty TextProperty =
          DependencyProperty.Register(nameof(Text), typeof(string),
            typeof(PasswordWithCheck), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty PlaceHolderProp =
  DependencyProperty.Register(nameof(placeHolder), typeof(string),
    typeof(PasswordWithCheck), new PropertyMetadata(string.Empty));


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pass.PasswordRevealMode = PasswordRevealMode.Visible;
        }

        private void Pass_GotFocus(object sender, RoutedEventArgs e)
        {
            pass.PasswordRevealMode = PasswordRevealMode.Visible;
        }

        private void Pass_LostFocus(object sender, RoutedEventArgs e)
        {
            pass.PasswordRevealMode = PasswordRevealMode.Hidden;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            pass.PasswordRevealMode = PasswordRevealMode.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            pass.PasswordRevealMode = PasswordRevealMode.Hidden;
        }
    }
}
