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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RatonTeclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MouseSobre(object sender, MouseEventArgs e)
        {
            TextBox_RatonSobre.Text = ((TextBox)sender).Name;
        }

        private void MouseFuera(object sender, MouseEventArgs e)
        {
            TextBox_RatonSobre.Text = "";
        }

        private void FocoSobre(object sender, RoutedEventArgs e)
        {
            TextBox_Foco.Text = ((TextBox)sender).Name;
        }

        private void ClickDerechoDown(object sender, MouseButtonEventArgs e)
        {
            TextBoxClickDerecho.Background = Brushes.Green;
        }

        private void PreviewClickIzquierdoDown(object sender, MouseButtonEventArgs e)
        {
            TextBoxClickIzquierdo.Background = Brushes.Green;
        }

        private void PreviewClickIzquierdoUp(object sender, MouseButtonEventArgs e)
        {
            TextBoxClickIzquierdo.Background = Brushes.White;
        }

        private void PreviewClickDerechoDown(object sender, MouseButtonEventArgs e)
        {
            TextBoxClickDerecho.Background = Brushes.Green;
        }

        private void PreviewClickDerechoUp(object sender, MouseButtonEventArgs e)
        {
            TextBoxClickDerecho.Background = Brushes.White;
        }

        private void PrecionarTecladoEvent(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.A:
                    e.Handled = true;
                    break;
                case Key.E:
                    e.Handled = true;
                    break;
                case Key.I:
                    e.Handled = true;
                    break;
                case Key.O:
                    e.Handled = true;
                    break;
                case Key.U:
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }

        private void TextBox_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBox_2.Text = "Ayuda";
            }
        }
    }
}
