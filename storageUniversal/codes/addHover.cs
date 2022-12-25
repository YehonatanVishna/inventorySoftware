using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace storageUniversal.codes
{
    class addHoverControlElement
    {
        private string txt;
        private object originalContent;
        public addHoverControlElement(ContentControl elem, string Txt)
        {
            txt = Txt;
            originalContent = elem.Content;
            elem.PointerEntered += Elem_PointerEntered;
            elem.PointerExited += Elem_PointerExited;
    }

        private void Elem_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            (sender as ContentControl).Content = originalContent;
        }

        private void Elem_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            (sender as ContentControl).Content = new TextBlock() { Text = txt, TextWrapping = new TextWrapping() };
        }
    }

}