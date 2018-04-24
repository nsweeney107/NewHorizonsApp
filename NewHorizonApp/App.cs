using NewHorizonApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace NewHorizonApp
{
    public partial class App
    {
        //protected override void OnActivated(IActivatedEventArgs args)
        //{
        //    if (args.Kind == ActivationKind.Protocol)
        //    {
        //        ProtocolActivatedEventArgs eventArgs = args as ProtocolActivatedEventArgs;
        //        if (eventArgs.Uri.IsAbsoluteUri)
        //        {
        //            DataHolder.NavigationTarget = new Uri(eventArgs.Uri.AbsoluteUri);
        //        }
        //    }
        //    else
        //    {
        //        base.OnActivated(args);
        //    }            
        //}
    }
}
