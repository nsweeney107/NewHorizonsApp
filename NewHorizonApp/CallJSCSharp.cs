using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewHorizonApp.ViewModels;
using Windows.Foundation.Metadata;

namespace NewHorizonApp
{
    [AllowForWeb]
    public sealed class CallJSCSharp
    {
        public void RedirectURL(string url)
        {
            DataHolder.UriName = url;
        }
    }
}
