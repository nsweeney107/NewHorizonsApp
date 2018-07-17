﻿#pragma checksum "E:\GitHub\NewHorizonsApp\NewHorizonApp\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "126A03A5D7E9C82620BA45B93E48595C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewHorizonApp
{
    partial class MainPage : 
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
                    this.TalkingAnimation = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 2:
                {
                    this.BlinkingAnimation = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 3:
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.Logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5:
                {
                    this.PatPortraitImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6:
                {
                    this.MouthImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.EyelidImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 370 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.EyelidImage).PointerEntered += this.MouseEntered;
                    #line 371 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.EyelidImage).PointerExited += this.MouseExited;
                    #line default
                }
                break;
            case 8:
                {
                    this.TextBubbleGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.ScrollViewer element9 = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                    #line 402 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)element9).ViewChanged += this.ScrollViewer_ViewChanged;
                    #line default
                }
                break;
            case 10:
                {
                    this.MainGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 11:
                {
                    this.SecondaryGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 12:
                {
                    this.RedStarButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 486 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RedStarButton).PointerEntered += this.MouseEntered;
                    #line 487 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RedStarButton).PointerExited += this.MouseExited;
                    #line 488 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RedStarButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 13:
                {
                    this.BrowseClassesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 503 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BrowseClassesButton).PointerEntered += this.MouseEntered;
                    #line 504 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BrowseClassesButton).PointerExited += this.MouseExited;
                    #line 505 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BrowseClassesButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 14:
                {
                    this.LaunchGameButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 520 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LaunchGameButton).PointerEntered += this.MouseEntered;
                    #line 521 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LaunchGameButton).PointerExited += this.MouseExited;
                    #line 522 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LaunchGameButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 15:
                {
                    this.SaveMoneyButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 537 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaveMoneyButton).PointerEntered += this.MouseEntered;
                    #line 538 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaveMoneyButton).PointerExited += this.MouseExited;
                    #line 539 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaveMoneyButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 16:
                {
                    this.HungryButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 554 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HungryButton).PointerEntered += this.MouseEntered;
                    #line 555 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HungryButton).PointerExited += this.MouseExited;
                    #line 556 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HungryButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 17:
                {
                    this.ShoppingButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 571 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShoppingButton).PointerEntered += this.MouseEntered;
                    #line 572 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShoppingButton).PointerExited += this.MouseExited;
                    #line 573 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShoppingButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 18:
                {
                    this.WhyCookiesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 587 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.WhyCookiesButton).PointerEntered += this.MouseEntered;
                    #line 588 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.WhyCookiesButton).PointerExited += this.MouseExited;
                    #line 589 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.WhyCookiesButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 19:
                {
                    this.VitalAcceleratorButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 605 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.VitalAcceleratorButton).PointerEntered += this.MouseEntered;
                    #line 606 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.VitalAcceleratorButton).PointerExited += this.MouseExited;
                    #line 607 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.VitalAcceleratorButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 20:
                {
                    this.FreeWebinars = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 621 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.FreeWebinars).PointerEntered += this.MouseEntered;
                    #line 622 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.FreeWebinars).PointerExited += this.MouseExited;
                    #line 623 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.FreeWebinars).Click += this.MouseClick;
                    #line default
                }
                break;
            case 21:
                {
                    this.faqButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 639 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.faqButton).PointerEntered += this.MouseEntered;
                    #line 640 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.faqButton).PointerExited += this.MouseExited;
                    #line 641 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.faqButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 22:
                {
                    this.questionButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 656 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.questionButton).PointerEntered += this.MouseEntered;
                    #line 657 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.questionButton).PointerExited += this.MouseExited;
                    #line 658 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.questionButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 23:
                {
                    this.YourClassButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 424 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.YourClassButton).PointerEntered += this.MouseEntered;
                    #line 425 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.YourClassButton).PointerExited += this.MouseExited;
                    #line 426 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.YourClassButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 24:
                {
                    this.DigitalReadingButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 441 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DigitalReadingButton).PointerEntered += this.MouseEntered;
                    #line 442 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DigitalReadingButton).PointerExited += this.MouseExited;
                    #line 443 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DigitalReadingButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 25:
                {
                    this.LabsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 458 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LabsButton).PointerEntered += this.MouseEntered;
                    #line 459 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LabsButton).PointerExited += this.MouseExited;
                    #line 460 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LabsButton).Click += this.MouseClick;
                    #line default
                }
                break;
            case 26:
                {
                    this.ButtonDescriptionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27:
                {
                    this.TitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28:
                {
                    this.SubtitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

