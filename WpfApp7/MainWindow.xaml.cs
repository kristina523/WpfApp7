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

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PeoplePage());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BrandsPage());
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PeopleBrandsPage());
        }
    }
}