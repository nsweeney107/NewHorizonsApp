using NewHorizonApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewHorizonApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            NavigationTarget = DataHolder.NavigationTarget;
            ButtonDescription = DataHolder.ButtonDescription;
            UriName = DataHolder.UriName;

            DataHolder.GlobalPropertyChanged += HandleGlobalPropertyChangedEvent;
        }

        private Uri navigationTarget = new Uri("https://www.google.com");

        public Uri NavigationTarget
        {
            get { return navigationTarget; }
            set
            {
                navigationTarget = value;
                OnPropertyChanged();
            }
        }

        private string buttonDescription;

        public string ButtonDescription
        {
            get { return buttonDescription; }
            set
            {
                buttonDescription = value;
                OnPropertyChanged();
            }
        }

        private string uriName;

        public string UriName
        {
            get { return uriName; }
            set
            {
                uriName = value;
                OnPropertyChanged();
            }
        }

        public void GetUrl(string buttonName)
        {
            Uri thisUri = new Uri("https://www.google.com");
            switch (buttonName)
            {
                case "YourClassButton": thisUri = new Uri("http://www.ClassButton.com");
                        break;
                case "DigitalReadingButton": thisUri = new Uri("http://www.DigitalReading.com");
                    break;
                    // TO DO - Implement other buttons

                default:
                    break;
            }
            NavigationTarget = thisUri;
            UriName = thisUri.ToString();
            //return NavigationTarget;
        }

        public void GetDescriptionText(string buttonName)
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
                // TO DO - Implement other buttons

                default:
                    break;
            }
            ButtonDescription = thisDescription;
            UriName = thisDescription;
            //return ButtonDescription;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void HandleGlobalPropertyChangedEvent(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "NavigationTarget": this.NavigationTarget = DataHolder.NavigationTarget;
                    break;
                case "UriName": this.UriName = DataHolder.UriName;
                    break;
                case "ButtonDescription": this.ButtonDescription = DataHolder.ButtonDescription;
                    break;
                default:
                    break;
            }
        }
    }
}
