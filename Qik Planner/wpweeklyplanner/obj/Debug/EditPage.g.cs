﻿#pragma checksum "C:\Users\krt\Documents\Visual Studio 2010\Projects\wpweeklyplanner\wpweeklyplanner\EditPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BB04E0FEA40BACBD4D55B88965295994"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace wpweeklyplanner {
    
    
    public partial class EditPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock AppTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.TimePicker StartsPicker;
        
        internal Microsoft.Phone.Controls.TimePicker EndsPicker;
        
        internal System.Windows.Controls.TextBox DescriptionInput;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/wpweeklyplanner;component/EditPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.AppTitle = ((System.Windows.Controls.TextBlock)(this.FindName("AppTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.StartsPicker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("StartsPicker")));
            this.EndsPicker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("EndsPicker")));
            this.DescriptionInput = ((System.Windows.Controls.TextBox)(this.FindName("DescriptionInput")));
        }
    }
}

