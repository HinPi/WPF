﻿#pragma checksum "..\..\..\AdminHome.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC9808EFD8CCECA23C2A16851BE4468932282FA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_Management;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Library_Management {
    
    
    /// <summary>
    /// AdminHome
    /// </summary>
    public partial class AdminHome : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\AdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel adminStackPanel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBooks;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\AdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUsers;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRequests;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\AdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAccepted;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogout;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\AdminHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReturn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library-Management;component/adminhome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminHome.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.adminStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.BtnBooks = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\AdminHome.xaml"
            this.BtnBooks.Click += new System.Windows.RoutedEventHandler(this.BtnBooks_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnUsers = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\AdminHome.xaml"
            this.BtnUsers.Click += new System.Windows.RoutedEventHandler(this.BtnUsers_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnRequests = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\AdminHome.xaml"
            this.BtnRequests.Click += new System.Windows.RoutedEventHandler(this.BtnRequests_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnAccepted = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\AdminHome.xaml"
            this.BtnAccepted.Click += new System.Windows.RoutedEventHandler(this.BtnAccepted_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\AdminHome.xaml"
            this.BtnLogout.Click += new System.Windows.RoutedEventHandler(this.BtnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\AdminHome.xaml"
            this.BtnReturn.Click += new System.Windows.RoutedEventHandler(this.BtnReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
