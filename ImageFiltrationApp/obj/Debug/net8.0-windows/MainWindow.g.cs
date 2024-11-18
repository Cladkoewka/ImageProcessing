﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D075858E0986E369080C7B75F7586FB6DE000D45"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ImageFiltrationApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ButtonsPanel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel CoordinateInputPanel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LeftTopXTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LeftTopYTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RightBottomXTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RightBottomYTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas CanvasOverlay;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageView;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle CropRectangle;
        
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
            System.Uri resourceLocater = new System.Uri("/ImageFiltrationApp;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            this.ButtonsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadImage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveImage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 14 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SharpenImage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 15 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CropAndResize_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 16 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConvertToGrayscale_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 17 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SmoothNoise_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CoordinateInputPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.LeftTopXTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.LeftTopXTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LeftTopXTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.LeftTopYTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.LeftTopYTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LeftTopYTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.RightBottomXTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\MainWindow.xaml"
            this.RightBottomXTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RightBottomXTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.RightBottomYTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.RightBottomYTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RightBottomYTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 32 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CropImage_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.CanvasOverlay = ((System.Windows.Controls.Canvas)(target));
            return;
            case 15:
            this.ImageView = ((System.Windows.Controls.Image)(target));
            return;
            case 16:
            this.CropRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
