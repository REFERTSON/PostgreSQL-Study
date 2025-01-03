﻿#pragma checksum "..\..\..\..\View\Inquirer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C87EC4AED8261C8C1893E36F73A926F08A168D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PostgreSQL_Study.View;
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


namespace PostgreSQL_Study.View {
    
    
    /// <summary>
    /// Inquirer
    /// </summary>
    public partial class Inquirer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\View\Inquirer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FileName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\Inquirer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunQueryButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\View\Inquirer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearQueryButton;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\View\Inquirer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExportResultButton;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\View\Inquirer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QueryTextBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\View\Inquirer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl TabResult;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\View\Inquirer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid InquirerItemTable;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\View\Inquirer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessageResult;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PostgreSQL-Study;component/view/inquirer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Inquirer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FileName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.RunQueryButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\View\Inquirer.xaml"
            this.RunQueryButton.Click += new System.Windows.RoutedEventHandler(this.RunQueryButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ClearQueryButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\View\Inquirer.xaml"
            this.ClearQueryButton.Click += new System.Windows.RoutedEventHandler(this.ClearQueryButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ExportResultButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\View\Inquirer.xaml"
            this.ExportResultButton.Click += new System.Windows.RoutedEventHandler(this.ExportResultButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.QueryTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\..\View\Inquirer.xaml"
            this.QueryTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.QueryTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TabResult = ((System.Windows.Controls.TabControl)(target));
            return;
            case 7:
            this.InquirerItemTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.MessageResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

