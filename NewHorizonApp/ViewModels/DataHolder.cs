using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewHorizonApp.ViewModels
{
    public static class DataHolder //: INotifyPropertyChanged
    {
        private static Uri navigationTarget = new Uri("https://www.google.com");

        public static Uri NavigationTarget
        {
            get { return navigationTarget; }
            set
            {
                navigationTarget = value;
                OnGlobalPropertyChanged("NavigationTarget");
            }
        }

        private static string buttonDescription;

        public static string ButtonDescription
        {
            get { return buttonDescription; }
            set
            {
                buttonDescription = value;
                OnGlobalPropertyChanged("ButtonDescription");
            }
        }

        private static string uriName;

        public static string UriName
        {
            get { return uriName; }
            set
            {
                uriName = value;
                OnGlobalPropertyChanged("UriName");
            }
        }

        public static void GetUrl(string buttonName)
        {
            Uri thisUri = new Uri("https://www.google.com");
            switch (buttonName)
            {
                case "YourClassButton":
                    thisUri = new Uri("https://lms.nhcms.net");
                    break;
                case "DigitalReadingButton":
                    thisUri = new Uri("http://www.DigitalReading.com");
                    break;
                case "LabsButton":
                    goto case "YourClassButton";
                case "BrowseClassesButton":
                    thisUri = new Uri("https://drive.google.com/open?id=1ic7ZKOjrgjyr6D35dC_xIDggAoc4VE0a");
                    break;
                case "FreeWebinars":
                    thisUri = new Uri("https://www.newhorizonswi.com/resources/free-webinars");
                    break;
                case "WhyCookiesButton":
                    thisUri = new Uri("https://drive.google.com/open?id=0ByY599NSZ0lEOUZ0TmFTeVdDRnM");
                    break;
                case "RedStarButton":
                    thisUri = new Uri("https://www.google.com");
                    break;
                case "faqButton":
                    thisUri = new Uri("https://drive.google.com/open?id=1Gx7ATClPOXmcgr-6pNTzjHhZqd8wHOE6");
                    break;
                case "VitalAcceleratorButton":
                    thisUri = new Uri("http://wwww.vitalaccelerator.com");
                    break;
                case "HeadsetButton":
                    thisUri = new Uri("https://drive.google.com/open?id=132vVkM_-pwuR3lHGFQWBzDBXhsqIbjif");
                    break;
                case "ShoppingButton":
                    thisUri = new Uri("https://drive.google.com/open?id=1fFGLLUBLf2zihM9q4VfFCsWBpHqzfMvw");
                    break;
                case "HungryButton":
                    thisUri = new Uri("https://drive.google.com/open?id=1MuGdyRfAG3aQDRcgWY86lrhzf45MN-77");
                    break;
                // TO DO - Implement other buttons
                // These are the buttons from the Courseware.xaml page
                case "skillpipeButton":
                    thisUri = new Uri("http://skillpipe.courseware-marketplace.com/reader");
                    break;
                case "nhChoiceButton":
                    thisUri = new Uri("http://www.nh-choice.com");
                    break;
                case "vitalsourceButton":
                    thisUri = new Uri("http://online.vitalsourcde.com/signin");
                    break;
                case "ciscoToolsButton":
                    thisUri = new Uri("http://online.vitalsourcde.com/signin");
                    break;
                case "ciscoLearningButton":
                    thisUri = new Uri("https://learningspace.cisco.com/");
                    break;
                default:
                    break;
            }
            NavigationTarget = thisUri;
            UriName = thisUri.ToString();
            //return NavigationTarget;
        }

        public static void GetDescriptionText(string buttonName)
        {
            string thisDescription = "";
            switch (buttonName)
            {
                case "EyelidImage":
                    thisDescription = "Hi, my name is Pat Riley and I am the president and owner of New Horizons of Wisconsin.  We created this portal to continue our quest to provide you, our student, with the finest experience possible.  On this page you will find a variety of items, each designed to either make your time with us easier, more comfortable, or just more fun.   I really LOVE to hear from our students, and if you click on the “Want to Tell Us Something?” box, you will have the opportunity to talk to me directly, and tell me anything you like.  If you can take just a few moments to tell me about your experience, I would really appreciate it.";
                    break;
                case "YourClassButton":
                    thisDescription = "Please click here to start your class.\rPlease note that your username is your email address and your password is P@ssword1";
                    break;
                case "DigitalReadingButton":
                    thisDescription = "Please click here to access your digital courseware.";
                    break;
                case "LabsButton":
                    thisDescription = "Please click here to start your labs.\rPlease note that your username is your email address and your password is P@ssword1";
                    break;
                case "BrowseClassesButton":
                    thisDescription = "Here you will find all of our courses, in an easy to navigate form, and you can take a deeper dive from there.  Also, please don’t forget about the “coupon” button, to save money on any other classes you like.";
                    break;
                case "FreeWebinars":
                    thisDescription = "Click here to register for one of our free webinars.";
                    break;
                case "WhyCookiesButton":
                    thisDescription = "Click here to watch a short, yet entertaining, video on the origins of our daily cookie baking tradition.  It'll make you hungry!";
                    break;
                case "RedStarButton":
                    thisDescription = "If you have a red star on your nametag, then please click here for all of the instructions you need to complete to launch your class experience with us.";
                    break;
                case "faqButton":
                    thisDescription = "Click here for the answers to all kinds of questions, from \"What is that grinding noise I hear?\" to \"How can I save more money on my training?\"";
                    break;
                case "VitalAcceleratorButton":
                    break;
                case "HeadsetButton":
                    break;
                case "ShoppingButton":
                    break;
                case "HungryButton":
                    break;
                // TO DO - Implement other buttons

                default:
                    break;
            }
            ButtonDescription = thisDescription;
            UriName = thisDescription;
            //return ButtonDescription;
        }

        public static event PropertyChangedEventHandler GlobalPropertyChanged = delegate { };

        public static void OnGlobalPropertyChanged(string propertyName)
        {
            GlobalPropertyChanged(typeof(DataHolder), new PropertyChangedEventArgs(propertyName));
        }
    }
}
