﻿#pragma checksum "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E015F3BC90D841E57A2C5A95D0A735DE5E701FDF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_HotelABC.Views.ManagerViews;
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


namespace Proyecto_HotelABC.Views.ManagerViews {
    
    
    /// <summary>
    /// ManagerMenu
    /// </summary>
    public partial class ManagerMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 123 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ManageEmployees;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_SignOff;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ViewReviews;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ManageServices;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LBL_WelcomeMessage;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ViewPayments;
        
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
            System.Uri resourceLocater = new System.Uri("/Proyecto_HotelABC;component/views/managerviews/managermenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
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
            this.BTN_ManageEmployees = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
            this.BTN_ManageEmployees.Click += new System.Windows.RoutedEventHandler(this.BTN_ManageEmployees_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_SignOff = ((System.Windows.Controls.Button)(target));
            
            #line 124 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
            this.BTN_SignOff.Click += new System.Windows.RoutedEventHandler(this.BTN_SignOff_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_ViewReviews = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
            this.BTN_ViewReviews.Click += new System.Windows.RoutedEventHandler(this.BTN_ViewReviews_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 126 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_ManagerBookings1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_ManageServices = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
            this.BTN_ManageServices.Click += new System.Windows.RoutedEventHandler(this.BTN_ManageServices_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LBL_WelcomeMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.BTN_ViewPayments = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\..\..\Views\ManagerViews\ManagerMenu.xaml"
            this.BTN_ViewPayments.Click += new System.Windows.RoutedEventHandler(this.BTN_ViewPays_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

