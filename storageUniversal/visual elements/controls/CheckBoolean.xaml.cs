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

namespace storageUniversal.visual_elements.controls
{
    public sealed partial class CheckBoolean : UserControl
    {
        public string icon
        {
            get
            {
                if (IsTrue)
                {
                    return "Clear";
                }
                return "Accept";
            }
        }

        public bool IsTrue { get => isTrue; set => isTrue = value; }

        private bool isTrue;
        public CheckBoolean()
        {
            this.InitializeComponent();
        }
        public static readonly DependencyProperty BoolProp =
  DependencyProperty.Register(nameof(IsTrue), typeof(Boolean),
    typeof(CheckBoolean), new PropertyMetadata(string.Empty));
    }
}
