﻿#pragma checksum "E:\GitHub\NewHorizonsApp\NewHorizonApp\Views\WebView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D40D6807A1FF16201BF3D962A2061890"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewHorizonApp.Views
{
    partial class WebView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MainWebView = (global::Windows.UI.Xaml.Controls.WebView)(target);
                    #line 68 "..\..\..\Views\WebView.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.MainWebView).UnsupportedUriSchemeIdentified += this.OnUnsupportedUriSchemeIdentified;
                    #line default
                }
                break;
            case 2:
                {
                    this.HomeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 77 "..\..\..\Views\WebView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HomeButton).Click += this.HomeButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 87 "..\..\..\Views\WebView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.ForwardButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 97 "..\..\..\Views\WebView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ForwardButton).Click += this.ForwardButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.StopButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 107 "..\..\..\Views\WebView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.StopButton).Click += this.StopButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.RefreshButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 117 "..\..\..\Views\WebView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RefreshButton).Click += this.RefreshButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

