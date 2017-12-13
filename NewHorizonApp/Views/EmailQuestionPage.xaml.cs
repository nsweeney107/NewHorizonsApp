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
using Windows.ApplicationModel.Email;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NewHorizonApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EmailQuestionPage : Page
    {
        public EmailQuestionPage()
        {
            this.InitializeComponent();
        }

        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage email = new EmailMessage();
            email.To.Add(new EmailRecipient("questions@nhwi.com"));
            email.Subject = "Question about class";
            email.Body = messageTextBox.Text;
            await EmailManager.ShowComposeNewEmailAsync(email);
            MessageDialog dlg = new MessageDialog("Thank you for your question!");
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
