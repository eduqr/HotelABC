﻿#pragma checksum "..\..\..\..\Views\PaymentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ECC32FA4A3F0F9D47F1035BA2CE40039FB0054"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_HotelABC.Views;
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


namespace Proyecto_HotelABC.Views {
    
    
    /// <summary>
    /// PaymentWindow
    /// </summary>
    public partial class PaymentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Views\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Price;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Pay;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBx_Owner;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBx_CardNumber;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Views\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBx_ExDateMonth;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Views\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBx_ExDateYear;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\Views\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBx_CVC;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto_HotelABC;V1.0.0.0;component/views/paymentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PaymentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Label_Price = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Button_Pay = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Views\PaymentWindow.xaml"
            this.Button_Pay.Click += new System.Windows.RoutedEventHandler(this.Pay);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtBx_Owner = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtBx_CardNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtBx_ExDateMonth = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxtBx_ExDateYear = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxtBx_CVC = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

