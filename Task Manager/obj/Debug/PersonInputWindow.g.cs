﻿#pragma checksum "..\..\PersonInputWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0E7340914EF1281A64D0B72BF6056B21"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using Task_Manager;


namespace Task_Manager {
    
    
    /// <summary>
    /// PersonInputWindow
    /// </summary>
    public partial class PersonInputWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\PersonInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxLastName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PersonInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxFirstName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PersonInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxMiddleName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PersonInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdAddPerson;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PersonInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdCancelAddPerson;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Task Manager;component/personinputwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PersonInputWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtboxLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtboxFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtboxMiddleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cmdAddPerson = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\PersonInputWindow.xaml"
            this.cmdAddPerson.Click += new System.Windows.RoutedEventHandler(this.cmdAddPerson_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmdCancelAddPerson = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\PersonInputWindow.xaml"
            this.cmdCancelAddPerson.Click += new System.Windows.RoutedEventHandler(this.cmdCancelAddPerson_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

