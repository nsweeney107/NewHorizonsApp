using NewHorizonApp.ViewModel;
using NewHorizonApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public sealed partial class WebView : Page
    {
        public MainViewModel ViewModel { get; set; }        

        public WebView()
        {
            this.InitializeComponent();

            ViewModel = new MainViewModel();
            //MainWebView.NavigationStarting += OnNavigationStarting;
            MainWebView.NavigationCompleted += OnNavigationCompleted;
            MainWebView.NewWindowRequested += OnNewWindowRequested;
            MainWebView.Navigate(ViewModel.NavigationTarget);
            ViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "UriName")
            {
                MainWebView.Navigate(ViewModel.NavigationTarget);
            }
        }

        private void OnNewWindowRequested(Windows.UI.Xaml.Controls.WebView sender, WebViewNewWindowRequestedEventArgs args)
        {
            Windows.UI.Xaml.Controls.WebView newWebView = new Windows.UI.Xaml.Controls.WebView();
            newWebView.Navigate(args.Uri);


            // Intercept the call to a new window and instead open it in the MainWebView
            MainWebView.Navigate(args.Uri);

            // Let the app know the event is handled
            args.Handled = true;
        }

        private void OnNavigationCompleted(Windows.UI.Xaml.Controls.WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            if (args.IsSuccess)
            {
                // Toggle the ForwardButton
                if (MainWebView.CanGoForward)
                {
                    ForwardButton.IsEnabled = true;
                }
                else
                {
                    ForwardButton.IsEnabled = false;
                }

                // Toggle the BackButton
                if (MainWebView.CanGoBack)
                {
                    BackButton.IsEnabled = true;
                }
                else
                {
                    BackButton.IsEnabled = false;
                }
            }
        }

        //private void OnNavigationStarting(Windows.UI.Xaml.Controls.WebView sender, WebViewNavigationStartingEventArgs args)
        //{
        //    sender.AddWebAllowedObject("CallJSCSharp", pObject: new CallJSCSharp());
        //}

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            MainWebView.Navigate(ViewModel.NavigationTarget);
            BackButton.IsEnabled = false;
            ForwardButton.IsEnabled = false;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWebView.Stop();
            Frame.Navigate(typeof(MainPage));
            OnHomeButtonClicked();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainWebView.CanGoBack)
            {
                MainWebView.GoBack();
            }
            //ForwardButton.IsEnabled = true;
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainWebView.CanGoForward)
            {
                MainWebView.GoForward();
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            MainWebView.Stop();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            MainWebView.Stop();
            MainWebView.Navigate(ViewModel.NavigationTarget);
        }

        private void TopCommandBar_Closing(object sender, object e)
        {
            CommandBar cb = sender as CommandBar;
            if (cb != null) cb.Background.Opacity = 0.5;
        }

        private void TopCommandBar_Opening(object sender, object e)
        {
            CommandBar cb = sender as CommandBar;
            if (cb != null) cb.Background.Opacity = 1.0;
        }

        public static event EventHandler HomeButtonClicked;

        public void OnHomeButtonClicked()
        {
            HomeButtonClicked?.Invoke(this, new EventArgs());
        }

        private void OnUnsupportedUriSchemeIdentified(Windows.UI.Xaml.Controls.WebView sender, WebViewUnsupportedUriSchemeIdentifiedEventArgs args)
        {
            if (args.Uri.Scheme != "href")
            {
                args.Handled = true;
                // TODO need to figure out what the URLs are from the PDFs
            }
        }
    }
}
