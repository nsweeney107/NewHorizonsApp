using NewHorizonApp.ViewModel;
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
using NewHorizonApp.Views;
using Windows.UI;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NewHorizonApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public MainViewModel ViewModel { get; set; }
        public string AccentColor { get; set; }

        public HomePage()
        {
            this.InitializeComponent();

            ViewModel = new MainViewModel();
            AccentColor = "#D13438";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.Visibility = Visibility.Visible;
        }

        private void MouseEntered(object sender, PointerRoutedEventArgs e)
        {
            var thisButton = sender as Button;
            if (thisButton != null)
            {
                var thisName = thisButton.Name.ToString();
                //ViewModel.GetDescriptionText(thisName);

                DataHolder.GetDescriptionText(thisName);
            }
            //thisButton.Background = GetColorFromHex(AccentColor);
            OnNavigationButtonHover();
        }

        private SolidColorBrush GetColorFromHex(string accentColor)
        {
            return new SolidColorBrush(
                Color.FromArgb(
                    255,
                    Convert.ToByte(accentColor.Substring(1, 2), 16),
                    Convert.ToByte(accentColor.Substring(3, 2), 16),
                    Convert.ToByte(accentColor.Substring(5, 2), 16)
                    )
                    );
        }

        private void MouseExited(object sender, PointerRoutedEventArgs e)
        {
            OnNavigationButtonUnHover();
        }

        private void MouseClick(object sender, RoutedEventArgs e)
        {
            var thisButton = sender as Button;
            if (thisButton != null)
            {
                var thisName = thisButton.Name.ToString();
                //ViewModel.GetUrl(thisName);
                DataHolder.GetUrl(thisName);
                this.Visibility = Visibility.Collapsed;
                Frame.Navigate(typeof(WebView));
                OnNavigationButtonClicked();
            }            
        }

        public static event EventHandler NavigationButtonClicked;

        public void OnNavigationButtonClicked()
        {
            NavigationButtonClicked?.Invoke(this, new EventArgs());
        }

        public static event EventHandler NavigationButtonHover;

        public void OnNavigationButtonHover()
        {
            //HoverColorAnimation.Begin();
            NavigationButtonHover?.Invoke(this, new EventArgs());
        }

        public static event EventHandler NavigationButtonUnHover;

        public void OnNavigationButtonUnHover()
        {
            NavigationButtonUnHover?.Invoke(this, new EventArgs());
        }
    }
}
