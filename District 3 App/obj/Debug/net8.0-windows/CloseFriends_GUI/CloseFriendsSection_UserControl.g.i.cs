﻿#pragma checksum "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AD66D9A0949D328BD0A9C982A09915CBEA87F846"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using District_3_App.CloseFriends_GUI;
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


namespace District_3_App.CloseFriends_GUI {
    
    
    /// <summary>
    /// CloseFriendsSection_UserControl
    /// </summary>
    public partial class CloseFriendsSection_UserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchCloseFriendsTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addNewCloseFriendButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeCloseFriendButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView closeFriendsListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/District 3 App;component/closefriends_gui/closefriendssection_usercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.searchCloseFriendsTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml"
            this.searchCloseFriendsTextBox.SelectionChanged += new System.Windows.RoutedEventHandler(this.searchCloseFriendsTextBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addNewCloseFriendButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml"
            this.addNewCloseFriendButton.Click += new System.Windows.RoutedEventHandler(this.addNewCloseFriendButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.removeCloseFriendButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\CloseFriends_GUI\CloseFriendsSection_UserControl.xaml"
            this.removeCloseFriendButton.Click += new System.Windows.RoutedEventHandler(this.removeCloseFriendButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.closeFriendsListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

