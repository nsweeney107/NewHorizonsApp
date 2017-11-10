using NewHorizonApp.ViewModel;
using NewHorizonApp.Views;
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
using System.Threading;
using System.ComponentModel;
using NewHorizonApp.ViewModels;
using System.Threading.Tasks;
using Windows.System.Threading;
using System.Collections.Concurrent;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NewHorizonApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; set; } //= new MainViewModel();
        public CancellationTokenSource ThisCTS { get; set; }
        public CancellationToken ThisCT { get; set; }
        public ConcurrentBag<Task> Tasks { get; set; }
        public string CurrentButtonColor { get; set; }
        public string HoverButtonColor { get; set; }

        public MainPage()
        {
            this.InitializeComponent();            

            // Wire this page up to the button events
            HomePage.NavigationButtonHover += HandleNavigationButtonHover;
            HomePage.NavigationButtonUnHover += HandleNavigationButtonUnHover;
            HomePage.NavigationButtonClicked += HandleNavigationButtonClicked;
            Views.WebView.HomeButtonClicked += HandleHomeButtonClicked;

            // Connect to the ViewModel
            ViewModel = new MainViewModel();

            // Create the Task Bag
            Tasks = new ConcurrentBag<Task>();

            ButtonDescriptionTextBlock.Text = "";

            // Set the button colors
            CurrentButtonColor = "CCCCCC";
            HoverButtonColor = "D13438";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            ButtonDescriptionTextBlock.Text = "";                        
            MainFrame.Navigate(typeof(HomePage));

            BlinkingAnimator();
        }

        public void HandleNavigationButtonClicked(object sender, EventArgs e)
        {
            ThisCTS.Cancel();
            ButtonDescriptionTextBlock.Text = "";
            HideEverything();
        }

        public void HandleHomeButtonClicked(object sender, EventArgs e)
        {
            UnHideEverything();
        }

        public void HandleNavigationButtonHover(object sender, EventArgs e)
        {
            // Clean up previous task (if any exists)
            if (ThisCTS != null)
            {
                ThisCTS.Cancel();
            }
            //CleanupCancellationToken();

            // Clear textblock
            ButtonDescriptionTextBlock.Text = "";

            // Get button description text from the viewmodel
            var descriptionText = ViewModel.ButtonDescription;

            // Create the token source for the Typewriter Task
            ThisCTS = new CancellationTokenSource();

            // Grab the token from the CancellationTokenSource 
            ThisCT = ThisCTS.Token;

            var spinWait = new SpinWait();

            var task = Task.Factory.StartNew(async () =>
            {
                // Were we already cancelled?
                //if (ThisCT.IsCancellationRequested)
                //{
                //    ThisCT.ThrowIfCancellationRequested();
                //}

                for (int i = 0; i < descriptionText.Length; i++)
                {
                    if (ThisCT.IsCancellationRequested)
                    {
                        //ThisCT.ThrowIfCancellationRequested();
                        break;
                    }

                    // Update the textblock
                    await ButtonDescriptionTextBlock.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        // Add another character to the ButtonDescriptionTextBlock
                        ButtonDescriptionTextBlock.Text += descriptionText[i];
                        if (descriptionText[i] != ' ')
                        {
                            for (int j = 0; j < 400; j++)
                            {
                                if (ThisCT.IsCancellationRequested)
                                {
                                    //ThisCT.ThrowIfCancellationRequested();
                                    break;
                                }
                                else
                                {
                                    spinWait.SpinOnce();
                                }
                            }
                        }
                    });

                    // Animate the mouth
                    if (i % 5 == 0)
                    {
                        await MouthImage.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                        {
                            TalkingAnimation.Begin();
                        });
                    }
                }
            }, ThisCT); // Pass the same token to StartNew

            // Add task to bag
            Tasks.Add(task);

            ////Just continue on this thread, or Wait/ Waitall with try-catch:
            //try
            //{
            //    task.Wait();
            //}
            //catch (AggregateException ae)
            //{
            //    ButtonDescriptionTextBlock.Text = "";
            //    ButtonDescriptionTextBlock.Text = "There was an error, here are the details:";
            //    foreach (var v in ae.InnerExceptions)
            //    {
            //        ButtonDescriptionTextBlock.Text += "\n" + ae.Message + " " + v.Message;
            //    }
            //}
            //finally
            //{
            //    CleanupCancellationToken();
            //}
        }

        public void HandleNavigationButtonUnHover(object sender, EventArgs e)
        {
            ThisCTS.Cancel();
        }

        private void CleanupCancellationToken()
        {
            if (ThisCTS != null)
            {
                ThisCTS.Cancel();
                //ButtonDescriptionTextBlock.Text = "";
                ThisCTS.Dispose();
                ThisCTS = null;
            }
        }

        private void HideEverything()
        {
            TitleTextBlock.Visibility = Visibility.Collapsed;
            PatPortraitImage.Visibility = Visibility.Collapsed;
            MouthImage.Visibility = Visibility.Collapsed;
            EyelidImage.Visibility = Visibility.Collapsed;
            ButtonDescriptionTextBlock.Visibility = Visibility.Collapsed;
        }

        private void UnHideEverything()
        {
            TitleTextBlock.Visibility = Visibility.Visible;
            PatPortraitImage.Visibility = Visibility.Visible;
            MouthImage.Visibility = Visibility.Visible;
            EyelidImage.Visibility = Visibility.Visible;
            ButtonDescriptionTextBlock.Visibility = Visibility.Visible;
        }

        private void BlinkingAnimator()
        {
            var spinWait = new SpinWait();

            var blinkingTask = Task.Factory.StartNew(async () =>
            {
                for (int i = 0; i < 60000; i++)
                {
                    await EyelidImage.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        // Animate the eyelids
                        if (i % 300 == 0)
                        {
                            BlinkingAnimation.Begin();
                        }                        
                    });

                    // Waste some time before checking for animation again
                    for (int j = 0; j < 200; j++)
                    {
                        spinWait.SpinOnce();
                    }
                }
            });

            // Add task to bag
            Tasks.Add(blinkingTask);
        }
    }
}
