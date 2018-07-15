using NewHorizonApp.ViewModels;
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

namespace NewHorizonApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Courseware : Page
    {
        public Courseware()
        {
            this.InitializeComponent();
        }

        private void HomeClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private async void WebsiteButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button thisButton)
            {
                var thisName = thisButton.Name.ToString();

                DataHolder.GetUrl(thisName);

                await Windows.System.Launcher.LaunchUriAsync(DataHolder.NavigationTarget);
                //Frame.Navigate(typeof(Views.WebView));
            }
        }
    }
}
