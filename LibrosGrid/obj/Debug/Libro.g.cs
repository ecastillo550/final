﻿#pragma checksum "..\..\Libro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "03785573AC4E95131BA0A532FC68B332"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
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


namespace LibrosGrid {
    
    
    /// <summary>
    /// Libro
    /// </summary>
    public partial class Libro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_libros;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nombre;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_idioma;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_pais;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_paginas;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_Autor;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_Editorial;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_Genero;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Libro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Guardar;
        
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
            System.Uri resourceLocater = new System.Uri("/LibrosGrid;component/libro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Libro.xaml"
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
            this.cmb_libros = ((System.Windows.Controls.ComboBox)(target));
            
            #line 7 "..\..\Libro.xaml"
            this.cmb_libros.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_idioma = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_pais = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_paginas = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cmb_Autor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\Libro.xaml"
            this.cmb_Autor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged_4);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmb_Editorial = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\Libro.xaml"
            this.cmb_Editorial.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged_3);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmb_Genero = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\Libro.xaml"
            this.cmb_Genero.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged_2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_Guardar = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Libro.xaml"
            this.btn_Guardar.Click += new System.Windows.RoutedEventHandler(this.btn_Guardar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

