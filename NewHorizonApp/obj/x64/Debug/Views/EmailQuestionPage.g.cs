﻿#pragma checksum "E:\GitHub\NewHorizonsApp\NewHorizonApp\Views\EmailQuestionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "64B3CC59C2D2125091E14B7991934849"
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
    partial class EmailQuestionPage : 
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
                    this.HomeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 79 "..\..\..\Views\EmailQuestionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HomeButton).Click += this.HomeButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.messageTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.SendButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 69 "..\..\..\Views\EmailQuestionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SendButton).Click += this.SendButton_Click;
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

