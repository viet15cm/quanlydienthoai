﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3684162D41E20E110C94F73CD593C09DC91C8512DA98D80FE8AA755946B49203"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using quanlydienthoai;


namespace quanlydienthoai {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKetnoi;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dulieu;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDulieu;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThem;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXoa;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtma;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdongia;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttonkho;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCapnhat;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbmakh;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDulieuall;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ch_cn;
        
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
            System.Uri resourceLocater = new System.Uri("/quanlydienthoai;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            
            #line 8 "..\..\Window1.xaml"
            ((quanlydienthoai.Window1)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnKetnoi = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Window1.xaml"
            this.btnKetnoi.Click += new System.Windows.RoutedEventHandler(this.btnKetnoi_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dulieu = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btnDulieu = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Window1.xaml"
            this.btnDulieu.Click += new System.Windows.RoutedEventHandler(this.btnDulieu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnThem = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Window1.xaml"
            this.btnThem.Click += new System.Windows.RoutedEventHandler(this.btnThem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnXoa = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Window1.xaml"
            this.btnXoa.Click += new System.Windows.RoutedEventHandler(this.btnXoa_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtma = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtdongia = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\Window1.xaml"
            this.txtdongia.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtdongia_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txttonkho = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnCapnhat = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Window1.xaml"
            this.btnCapnhat.Click += new System.Windows.RoutedEventHandler(this.btnCapnhat_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cbmakh = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\Window1.xaml"
            this.cbmakh.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbmakh_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnDulieuall = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Window1.xaml"
            this.btnDulieuall.Click += new System.Windows.RoutedEventHandler(this.btnDulieuall_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ch_cn = ((System.Windows.Controls.CheckBox)(target));
            
            #line 32 "..\..\Window1.xaml"
            this.ch_cn.Click += new System.Windows.RoutedEventHandler(this.ch_cn_Click);
            
            #line default
            #line hidden
            
            #line 32 "..\..\Window1.xaml"
            this.ch_cn.Checked += new System.Windows.RoutedEventHandler(this.ch_cn_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
