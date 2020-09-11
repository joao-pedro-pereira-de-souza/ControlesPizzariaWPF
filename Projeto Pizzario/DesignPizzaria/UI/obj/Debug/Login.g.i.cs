﻿#pragma checksum "..\..\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1E285A827F766BE6C36CA4F43E5BEFDE61B33BF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using UI;


namespace UI {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlTop;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.IconPacks.PackIconMaterial btnSair;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtSenha;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEscSenha;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border btnLogar;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border btnCadastrar;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbcad;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Login.xaml"
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
            this.pnlTop = ((System.Windows.Controls.StackPanel)(target));
            
            #line 29 "..\..\Login.xaml"
            this.pnlTop.AddHandler(System.Windows.ContentElement.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.PnlTop_MouseDown));
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSair = ((MahApps.Metro.IconPacks.PackIconMaterial)(target));
            
            #line 30 "..\..\Login.xaml"
            this.btnSair.AddHandler(System.Windows.ContentElement.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.BtnSair_MouseDown));
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtSenha = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.lblEscSenha = ((System.Windows.Controls.Label)(target));
            
            #line 55 "..\..\Login.xaml"
            this.lblEscSenha.AddHandler(System.Windows.ContentElement.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.LblEscSenha_MouseDown));
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnLogar = ((System.Windows.Controls.Border)(target));
            
            #line 60 "..\..\Login.xaml"
            this.btnLogar.AddHandler(System.Windows.ContentElement.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.BtnLogar_MouseDown));
            
            #line default
            #line hidden
            
            #line 60 "..\..\Login.xaml"
            this.btnLogar.AddHandler(System.Windows.ContentElement.MouseEnterEvent, new System.Windows.Input.MouseEventHandler(this.BtnLogar_MouseEnter));
            
            #line default
            #line hidden
            
            #line 60 "..\..\Login.xaml"
            this.btnLogar.AddHandler(System.Windows.ContentElement.MouseLeaveEvent, new System.Windows.Input.MouseEventHandler(this.BtnLogar_MouseLeave));
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCadastrar = ((System.Windows.Controls.Border)(target));
            
            #line 64 "..\..\Login.xaml"
            this.btnCadastrar.AddHandler(System.Windows.ContentElement.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.BtnCadastrar_MouseDown));
            
            #line default
            #line hidden
            
            #line 64 "..\..\Login.xaml"
            this.btnCadastrar.AddHandler(System.Windows.ContentElement.MouseEnterEvent, new System.Windows.Input.MouseEventHandler(this.BtnCadastrar_MouseEnter));
            
            #line default
            #line hidden
            
            #line 64 "..\..\Login.xaml"
            this.btnCadastrar.AddHandler(System.Windows.ContentElement.MouseLeaveEvent, new System.Windows.Input.MouseEventHandler(this.BtnCadastrar_MouseLeave));
            
            #line default
            #line hidden
            return;
            case 8:
            this.txbcad = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
