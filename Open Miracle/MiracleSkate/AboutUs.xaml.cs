﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiracleSkate
{
    /// <summary>
    /// Interaction logic for AboutUs.xaml
    /// </summary>
    public partial class AboutUs : UserControl
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Grid).Children.Remove(this);
        }
    }
}