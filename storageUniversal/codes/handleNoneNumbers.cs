using Windows.UI.Xaml.Controls;

namespace storageUniversal
{
    class handleNoneNumbers
    {
        //מבטל הוספת תווים שאינם מספר לשדות מספריים
        public static void Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Get the current text of the textbox
            string text = (sender as TextBox).Text;

            // Loop through each character in the text
            string newText = text;
            foreach (char c in text)
            {
                // If the character is not a digit
                if (!char.IsDigit(c) && c != '.')
                {
                    newText = newText.Remove(newText.IndexOf(c), 1);
                }
            }
            (sender as TextBox).Text = newText;

        }
    }

}