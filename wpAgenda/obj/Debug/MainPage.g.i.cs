﻿#pragma checksum "c:\users\ryuuzak\documents\visual studio 2013\Projects\wpAgenda\wpAgenda\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9EBFED05E7527B61FEF03E5DA253F527"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
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


namespace wpAgenda {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox taskListBox;
        
        internal System.Windows.Controls.TextBox txtNome;
        
        internal System.Windows.Controls.TextBox txtTel;
        
        internal System.Windows.Controls.TextBox txtAp;
        
        internal System.Windows.Controls.Button btnCad;
        
        internal System.Windows.Controls.Button btnExc;
        
        internal System.Windows.Controls.Button btnPesq;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/wpAgenda;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.taskListBox = ((System.Windows.Controls.ListBox)(this.FindName("taskListBox")));
            this.txtNome = ((System.Windows.Controls.TextBox)(this.FindName("txtNome")));
            this.txtTel = ((System.Windows.Controls.TextBox)(this.FindName("txtTel")));
            this.txtAp = ((System.Windows.Controls.TextBox)(this.FindName("txtAp")));
            this.btnCad = ((System.Windows.Controls.Button)(this.FindName("btnCad")));
            this.btnExc = ((System.Windows.Controls.Button)(this.FindName("btnExc")));
            this.btnPesq = ((System.Windows.Controls.Button)(this.FindName("btnPesq")));
        }
    }
}

