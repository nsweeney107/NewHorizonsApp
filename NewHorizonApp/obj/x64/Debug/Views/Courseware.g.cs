﻿#pragma checksum "E:\GitHub\NewHorizonsApp\NewHorizonApp\Views\Courseware.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "147266F95DFF59AE5BE51689D36B8CCC"
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
    partial class Courseware : 
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
                    this.MicrosoftTechnicalCourseware = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.ApplicationCourses = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.vmWare = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    this.cisco = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 177 "..\..\..\Views\Courseware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.HomeClick;
                    #line default
                }
                break;
            case 6:
                {
                    this.ciscoToolsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 155 "..\..\..\Views\Courseware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ciscoToolsButton).Click += this.WebsiteButtonClick;
                    #line default
                }
                break;
            case 7:
                {
                    this.ciscoLearningButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 169 "..\..\..\Views\Courseware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ciscoLearningButton).Click += this.WebsiteButtonClick;
                    #line default
                }
                break;
            case 8:
                {
                    this.vitalsourceButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 135 "..\..\..\Views\Courseware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.vitalsourceButton).Click += this.WebsiteButtonClick;
                    #line default
                }
                break;
            case 9:
                {
                    this.nhChoiceButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 109 "..\..\..\Views\Courseware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.nhChoiceButton).Click += this.WebsiteButtonClick;
                    #line default
                }
                break;
            case 10:
                {
                    this.skillpipeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 75 "..\..\..\Views\Courseware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.skillpipeButton).Click += this.WebsiteButtonClick;
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

