﻿#pragma checksum "C:\Users\konugantis\Documents\Visual Studio 2013\Projects\PDFReaderLauncher\PDFReaderLauncher\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB102042E6F4864DEFBBBA965C9286EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace PDFReaderLauncher {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button downloadButton;
        
        internal System.Windows.Controls.Button downloadsFolder;
        
        internal System.Windows.Controls.Button storageFolder;
        
        internal System.Windows.Controls.Button resourceButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PDFReaderLauncher;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.downloadButton = ((System.Windows.Controls.Button)(this.FindName("downloadButton")));
            this.downloadsFolder = ((System.Windows.Controls.Button)(this.FindName("downloadsFolder")));
            this.storageFolder = ((System.Windows.Controls.Button)(this.FindName("storageFolder")));
            this.resourceButton = ((System.Windows.Controls.Button)(this.FindName("resourceButton")));
        }
    }
}

