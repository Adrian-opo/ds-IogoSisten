﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IogoSistem_vs1
{
    /// <summary>
    /// Lógica interna para SuporteUsuario.xaml
    /// </summary>
    public partial class SuporteUsuario : Window
    {
        public SuporteUsuario()
        {
            InitializeComponent();
        }

        private void BtnManual(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\adria\OneDrive\Área de Trabalho\teste.docx");
        }
    }
}
