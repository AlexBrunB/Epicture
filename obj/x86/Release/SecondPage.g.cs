﻿#pragma checksum "D:\dotnet\DotNet_epicture_2016\SecondPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6D49BBF4396CC0F1B3251AACB43B7B00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNet_epicture_2016
{
    partial class SecondPage : 
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
                    this.GridViewAlbum = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 20 "..\..\..\SecondPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.GridViewAlbum).SelectionChanged += this.GridViewAlbum_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.buttonFav = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\SecondPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonFav).Click += this.buttonFav_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.buttonDelete = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\SecondPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonDelete).Click += this.buttonDelete_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.buttonSearch = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\SecondPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonSearch).Click += this.buttonSearch_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.searchBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 12 "..\..\..\SecondPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.buttonGalHot_Click;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element8 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 13 "..\..\..\SecondPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element8).Click += this.buttonGalUser_Click;
                    #line default
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element9 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 14 "..\..\..\SecondPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element9).Click += this.buttonGalFav_Click;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element10 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 15 "..\..\..\SecondPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element10).Click += this.buttonUpload_Click;
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

