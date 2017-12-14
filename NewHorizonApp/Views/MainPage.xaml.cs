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
using Windows.UI.Xaml.Hosting;
using Windows.Media.SpeechSynthesis;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NewHorizonApp
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; set; } //= new MainViewModel();
        public string ThisGuid;
        public ConcurrentBag<Task> Tasks { get; set; }
        public string _descriptionText = "";
        public bool _descriptionUpdate = false;
        public bool _running = true;
        public MediaElement mediaElement = new MediaElement();
        public bool _speaking = false;


        public MainPage()
        {
            this.InitializeComponent();

            // Connect to the ViewModel
            ViewModel = new MainViewModel();

            // Wire up to speaking event
            Speaking += HandleSpeakingEvent;

            // Create the Task Bag
            Tasks = new ConcurrentBag<Task>();

            ButtonDescriptionTextBlock.Text = "";

            var task = Task.Factory.StartNew(async () =>
            {
                while (_running)
                {
                    try
                    {
                        string descriptionText = _descriptionText;
                        _descriptionUpdate = false;

                        await ButtonDescriptionTextBlock.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                        {
                            ButtonDescriptionTextBlock.Text = "";
                        });

                        for (int i = 0; i < descriptionText.Length; i++)
                        {
                            if (_descriptionText != descriptionText)
                            {
                                descriptionText = _descriptionText;
                                break;
                            }
                            
                            // Update the textblock
                            await ButtonDescriptionTextBlock.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                            {
                                if (_descriptionText == descriptionText)
                                {
                                    ButtonDescriptionTextBlock.Text += descriptionText[i];
                                    //System.Diagnostics.Debug.WriteLine("descriptionText: " + descriptionText[i].ToString());
                                }
                            });

                            if (_descriptionText == descriptionText && descriptionText[i] != ' ')
                                System.Threading.Tasks.Task.Delay(50).Wait();

                            if (_descriptionText != descriptionText)
                                break;

                            // Animate the mouth
                            //if (i % 5 == 0)
                            //{
                            //    //                                System.Diagnostics.Debug.WriteLine("Animation Start: " + ThisCT.IsCancellationRequested.ToString());
                            //    await MouthImage.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                            //    {
                            //        TalkingAnimation.Begin();
                            //    });
                            //    //                              System.Diagnostics.Debug.WriteLine("Animation End: " + ThisCT.IsCancellationRequested.ToString());
                            //}
                        }

                        if (_descriptionText == descriptionText)
                            _descriptionText = descriptionText = "";

                        while (_descriptionUpdate == false)
                            System.Threading.Tasks.Task.Delay(50).Wait(); 
                    }
                    catch (Exception ee)
                    {
                        System.Diagnostics.Debug.WriteLine("Task Exeception: " + ee.Message.ToString());
                        System.Diagnostics.Debug.WriteLine("Task StackTrace: " + ee.StackTrace.ToString());
                    }
                }

            });
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
            SpeakText(DataHolder.ButtonDescription);
            TypewriterTextFiller();
            OnSpeaking();
            AnimateMouth();
        }

        private static void GetButtonDescriptionText(object sender)
        {
            string thisName = "";
            if (sender is Button)
            {
                var thisButton = sender as Button;
                if (thisButton != null)
                {
                    thisName = thisButton.Name.ToString();
                }                
            }
            else if (sender is Image)
            {
                var thisImage = sender as Image;
                if (thisImage != null)
                {
                    thisName = thisImage.Name.ToString();
                }
            }
            if (thisName != "")
            {
                DataHolder.GetDescriptionText(thisName);
            }
            //var thisButton = sender as Button;
            //if (thisButton != null)
            //{
            //    var thisName = thisButton.Name.ToString();

            //    DataHolder.GetDescriptionText(thisName);
            //}
        }

        private async void SpeakText(string textToSpeak)
        {
            // The object for controlling the speech synthesis engine
            using (var synth = new SpeechSynthesizer())
            {
                // Set the voice
                synth.Voice = SpeechSynthesizer.AllVoices.First(gender => gender.Gender == VoiceGender.Male);

                // Generate the audio stream from the passed in string
                SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(textToSpeak);

                // Send the stream to the media object
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }

        public event EventHandler Speaking = delegate { };

        protected void OnSpeaking()
        {
            Speaking?.Invoke(this, new EventArgs());
        }

        private void HandleSpeakingEvent(object sender, EventArgs e)
        {
            if (_speaking == true)
            {
                _speaking = false;
            }
            else
            {
                _speaking = true;
            }
        }

        private async void AnimateMouth()
        {
            //var descriptionText = _descriptionText;

            var animationTask = Task.Factory.StartNew(async () =>
            {
                while (_speaking)
                {
                    for (int i = 0; i < 3000; i++)
                    {
                        if (!_speaking)
                            break;

                        // Animate the mouth
                        if (i % 5 == 0)
                        {
                            //                                System.Diagnostics.Debug.WriteLine("Animation Start: " + ThisCT.IsCancellationRequested.ToString());
                            await MouthImage.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                            {
                                TalkingAnimation.Begin();
                            });
                            // System.Diagnostics.Debug.WriteLine("Animation End: " + ThisCT.IsCancellationRequested.ToString());
                        }
                        System.Threading.Tasks.Task.Delay(50).Wait();
                    };
                }
            });

            //Tasks.Add(animationTask);
        }

        private void TypewriterTextFiller()
        {
            try
            {
                // Get button description text from the viewmodel
                _descriptionText = ViewModel.ButtonDescription;
                _descriptionUpdate = true;
            }
            catch (Exception ee)
            {
                System.Diagnostics.Debug.WriteLine("TypewriterTextFiller Exeception: " + ee.Message.ToString());
            }
        }

        private void MouseExited(object sender, PointerRoutedEventArgs e)
        {
            CancelTask();
            mediaElement.Stop();
            OnSpeaking();
        }

        private void CancelTask()
        {
            _descriptionText = "";
            _descriptionUpdate = true;
        }

        private void MouseClick(object sender, RoutedEventArgs e)
        {
            CancelTask();

            var thisButton = sender as Button;
            if (thisButton != null)
            {
                var thisName = thisButton.Name.ToString();

                switch (thisName)
                {
                    case "DigitalReadingButton":
                        Frame.Navigate(typeof(Courseware));
                        break;
                    case "questionButton":
                        Frame.Navigate(typeof(EmailQuestionPage));
                        break;
                    default:
                        DataHolder.GetUrl(thisName);
                        Frame.Navigate(typeof(Views.WebView));
                        break;
                }
                //if (thisName == "DigitalReadingButton")
                //{
                //    Frame.Navigate(typeof(Courseware));
                //}
                //else
                //{
                //    DataHolder.GetUrl(thisName);
                //    Frame.Navigate(typeof(Views.WebView));
                //}
            }
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }
    }
}
