﻿#pragma checksum "..\..\..\..\..\..\Proyecto_HotelABC\Views\EmployeeViews\EmployeeMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29E5DEBC5799E0140F4D56DDE7D223028DD42AE6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_HotelABC.Views.EmployeeViews;
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


namespace Proyecto_HotelABC.Views.EmployeeViews {
    
    
    /// <summary>
    /// EmployeeMenu
    /// </summary>
    public partial class EmployeeMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\..\Proyecto_HotelABC\Views\EmployeeViews\EmployeeMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ManageGuest;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\Proyecto_HotelABC\Views\EmployeeViews\EmployeeMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_SignOff;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto_HotelABC;component/proyecto_hotelabc/views/employeeviews/employeemenu.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Proyecto_HotelABC\Views\EmployeeViews\EmployeeMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BTN_ManageGuest = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\..\..\Proyecto_HotelABC\Views\EmployeeViews\EmployeeMenu.xaml"
            this.BTN_ManageGuest.Click += new System.Windows.RoutedEventHandler(this.BTN_ManageGuest_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_SignOff = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\..\Proyecto_HotelABC\Views\EmployeeViews\EmployeeMenu.xaml"
            this.BTN_SignOff.Click += new System.Windows.RoutedEventHandler(this.BTN_SignOff_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

