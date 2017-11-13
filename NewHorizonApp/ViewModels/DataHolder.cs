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
        private static string accentColor = "#D13438";

        public static string AccentColor
        {
            get { return accentColor; }
            set
            {
                accentColor = value;
                OnGlobalPropertyChanged("AccentColor");
            }
        }

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
        //public Uri NavigationTarget { get; set; } = new Uri("https://www.google.com");
        //public string ButtonDescription { get; set; } = "";
        //public string UriName { get; set; } = "";

        public static void GetUrl(string buttonName)
        {
            Uri thisUri = new Uri("https://www.google.com");
            switch (buttonName)
            {
                case "YourClassButton":
                    thisUri = new Uri("http://www.ClassButton.com");
                    break;
                case "DigitalReadingButton":
                    thisUri = new Uri("http://www.DigitalReading.com");
                    break;
                case "LabsButton":
                    thisUri = new Uri("http://www.labs.com/");
                    break;
                // TO DO - Implement other buttons

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
                case "YourClassButton":
                    thisDescription = "Class Button";
                    break;
                case "DigitalReadingButton":
                    thisDescription = "Digital Reading";
                    break;
                case "LabsButton":
                    thisDescription = "Click on this button to access the labs for your class.  Please have your username and password handy as you will need them to log into the portal.";
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
