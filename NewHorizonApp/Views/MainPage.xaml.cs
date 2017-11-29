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
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; set; } //= new MainViewModel();
        public CancellationTokenSource ThisCTS { get; set; }
        public CancellationToken ThisCT { get; set; }
        public ConcurrentBag<Task> Tasks { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            // Connect to the ViewModel
            ViewModel = new MainViewModel();

            // Create the Task Bag
            Tasks = new ConcurrentBag<Task>();

            ButtonDescriptionTextBlock.Text = "";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //WaitABit(250);
            ButtonDescriptionTextBlock.Text = "";

            BlinkingAnimator();
        }
        
        private void WaitABit(int timeToWait)
        {
            var spinWait = new SpinWait();
            for (int i = 0; i < timeToWait; i++)
            {
                spinWait.SpinOnce();
            }
        }
       
        private void BlinkingAnimator()
        {
            //var spinWait = new SpinWait();

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
                    WaitABit(200);
                }
            });

            // Add task to bag
            Tasks.Add(blinkingTask);
        }

        // These all came from the old HomePage.xaml.cs
        private void MouseEntered(object sender, PointerRoutedEventArgs e)
        {
            GetButtonDescriptionText(sender);
            TypewriterTextFiller();
        }

        private static void GetButtonDescriptionText(object sender)
        {
            var thisButton = sender as Button;
            if (thisButton != null)
            {
                var thisName = thisButton.Name.ToString();

                DataHolder.GetDescriptionText(thisName);
            }
        }

        private void TypewriterTextFiller()
        {
            // Clean up previous task (if any exists)
            CancelTask();

            // Wait for the task to cancel
            //WaitForTypewriterToCancel();

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
                for (int i = 0; i < descriptionText.Length; i++)
                {
                    if (ThisCT.IsCancellationRequested)
                    {
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
        }

        private void WaitForTypewriterToCancel()
        {
            //if (TasksList.Count == 2)
            //{
            //    var thisTask = (Task)TasksList.ElementAt(1);

            //    if (thisTask != null)
            //    {
            //        thisTask.Wait();
            //    }
            //}                 
        }


        private void MouseExited(object sender, PointerRoutedEventArgs e)
        {
            CancelTask();
        }

        private void CancelTask()
        {
            if (ThisCTS != null)
            {
                ThisCTS.Cancel();
            }
        }

        private void MouseClick(object sender, RoutedEventArgs e)
        {
            CancelTask();

            var thisButton = sender as Button;
            if (thisButton != null)
            {
                var thisName = thisButton.Name.ToString();
                DataHolder.GetUrl(thisName);
                Frame.Navigate(typeof(Views.WebView));
            }
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }
    }
}
