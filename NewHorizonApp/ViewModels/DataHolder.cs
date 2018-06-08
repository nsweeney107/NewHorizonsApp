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
                    //thisUri = new Uri("https://drive.google.com/open?id=1ic7ZKOjrgjyr6D35dC_xIDggAoc4VE0a");
                    thisUri = new Uri("ms-appx-web:///WebPages/CourseCatelog.htm");
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
                    thisUri = new Uri("http://vitalaccelerator.com");
                    break;
                case "HeadsetButton":
                    thisUri = new Uri("https://drive.google.com/open?id=132vVkM_-pwuR3lHGFQWBzDBXhsqIbjif");
                    break;
                //case "ShoppingButton":
                //    thisUri = new Uri("https://drive.google.com/open?id=1fFGLLUBLf2zihM9q4VfFCsWBpHqzfMvw");
                //    break;
                //case "HungryButton":
                //    thisUri = new Uri("https://drive.google.com/open?id=1MuGdyRfAG3aQDRcgWY86lrhzf45MN-77");
                //    break;
                case "questionButton":
                    thisUri = new Uri("https://lc.chat/now/7026351/");
                    break;

                // These are the buttons from the Courseware.xaml page
                case "skillpipeButton":
                    thisUri = new Uri("http://skillpipe.courseware-marketplace.com/reader");
                    break;
                case "nhChoiceButton":
                    thisUri = new Uri("http://www.nh-choice.com");
                    break;
                case "vitalsourceButton":
                    thisUri = new Uri("http://online.vitalsource.com/signin");
                    break;
                case "ciscoToolsButton":
                    thisUri = new Uri("https://tools.cisco.com/IDREG/guestRegistration");
                    break;
                case "ciscoLearningButton":
                    thisUri = new Uri("https://learningspace.cisco.com/");
                    break;

                // These are the buttons from the Food.xaml page
                case "AppletonButton":
                    //thisUri = new Uri("https://drive.google.com/open?id=1m1pU1q4N3ncwpxDNstTzZRZpKG6qk7y4");
                    thisUri = new Uri("ms-appx-web:///WebPages/AppletonHungry.html");
                    break;
                case "City2Button":
                    //thisUri = new Uri("https://drive.google.com/open?id=1YhP_jzKqJ2BHe2jRFZhTiqzmqwQlY45g");
                    thisUri = new Uri("ms-appx-web:///WebPages/BrookfieldHungry.html");
                    break;
                case "City3Button":
                    //thisUri = new Uri("https://drive.google.com/open?id=1UWV1GNY0khxEn3h3469F9bSTNMxTzyk7");
                    thisUri = new Uri("ms-appx-web:///WebPages/MadisonHungry.html");
                    break;

                // These are the buttons from the Shopping.xaml page
                case "AppletonShopButton":
                    //thisUri = new Uri("https://drive.google.com/open?id=1dVEKMpcaqRylUm3CQxjWd1_eTDwQLVir");
                    thisUri = new Uri("ms-appx-web:///WebPages/AppletonShopping.html");
                    break;
                case "BrookfieldShopButton":
                    //thisUri = new Uri("https://drive.google.com/open?id=1ppdlGfXl-iZcUfKkWf0UP-mZ_7_PzGE9");
                    thisUri = new Uri("ms-appx-web:///WebPages/BrookfieldShopping.html");
                    break;
                case "MadisonShopButton":
                    //thisUri = new Uri("https://drive.google.com/open?id=1snNCTPVLtgJdSelmsgpouAooFN9LQDvW");
                    thisUri = new Uri("ms-appx-web:///WebPages/MadisonShopping.html");
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
                    thisDescription = "Before you toss your headset in the garabage on the way out the door, click this button to see what we do with the unwanted headsets!";
                    break;
                case "ShoppingButton":
                    thisDescription = "So your class is out early, but you don't feel like going back to work?  Click this button to see what stores are nearby to kill some time at.";
                    break;
                case "HungryButton":
                    thisDescription = "So it's lunch-time, but you're in a new city.  Fear not!  Click on this button to see what restaurants are nearby!";
                    break;
                case "questionButton":
                    thisDescription = "Have a question?  Click here to submit it to us, we'd love to hear from you!";
                    break;

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
