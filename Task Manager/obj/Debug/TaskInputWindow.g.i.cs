﻿#pragma checksum "..\..\TaskInputWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0B177EF2D3E5907585C5459A14ED2535"
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
    /// TaskInputWindow
    /// </summary>
    public partial class TaskInputWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\TaskInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxTaskName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\TaskInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxTaskTask;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\TaskInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTaskStartDate;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\TaskInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxTaskEndDate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\TaskInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboStatus;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\TaskInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboPersons;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\TaskInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdAddTask;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\TaskInputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdCancelAddTask;
        
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
            System.Uri resourceLocater = new System.Uri("/Task Manager;component/taskinputwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TaskInputWindow.xaml"
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
            this.txtboxTaskName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtboxTaskTask = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtTaskStartDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtboxTaskEndDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cboStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cboPersons = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.cmdAddTask = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\TaskInputWindow.xaml"
            this.cmdAddTask.Click += new System.Windows.RoutedEventHandler(this.cmdAddTask_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmdCancelAddTask = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\TaskInputWindow.xaml"
            this.cmdCancelAddTask.Click += new System.Windows.RoutedEventHandler(this.cmdCancelAddTask_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

